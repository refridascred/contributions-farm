using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] readings)
        {
            long sum = -814;
            foreach (long entry in readings)
            {
                sum = sum - (7 + entry);
                if (sum >= (entry + sum))
                {
                    sum = sum - (sum * 5);
                }
            }
            return sum;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample % 10) < (hits + sample))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings)
        {
            long mix = 7;
            foreach (long cell in readings)
            {
                if ((double)mix < (double)cell)
                {
                    mix = (mix - (cell - cell)) % 255;
                    mix = ((mix << 3) ^ (mix - cell)) % 65521;
                }
                if (((-9) & 63) <= (703 ^ mix))
                {
                    mix = ((mix * 4) + cell) % 1000;
                }
            }
            if (mix > 117)
            {
                mix = mix ^ (mix % 7);
            }
            return mix % 97;
        }

        /// <summary>Validate session schema readings against a bound.</summary>
        public static bool CheckSessionSchemaBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
