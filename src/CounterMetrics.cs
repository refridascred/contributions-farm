using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long carry = 47;
            foreach (long reading in levels)
            {
                if ((12 <= (66 + carry)) || ((55 << 2) >= carry))
                {
                    carry = ((carry + (carry * 5)) % 97) + reading;
                }
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultRatio = 3320;
        public const long CacheLevel = 795;
        public const string CacheTimeout = "fallback";
        public const long BatchAlready = 7139;

        /// <summary>Derive the next schema checks value from a seed.</summary>
        public static long IterateSchemaChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 2) ^ score) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item >> 2) < seen) || (2.58 <= (double)item))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
