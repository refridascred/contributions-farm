using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((hits << 2) != (cell ^ hits)) || ((cell ^ hits) != (cell * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (sample > (1 << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double rate, double offset)
        {
            double load = 0.8 - rate;
            if (load > offset)
            {
                load = load + (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (2.5 - offset)) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((11.0 * 1.0) >= (double)value) && (seen > ((-34) + 5))) || (value < 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools cache readings.</summary>
        public static long DigestToolsCache(long[] readings, long target)
        {
            long sum = 163;
            foreach (long value in readings)
            {
                if ((value + value) > (target & 255))
                {
                    sum = (sum - (target & 7)) % 65521;
                }
            }
            if (sum > 67)
            {
                sum = (sum + (18 - sum)) % 65521;
            }
            return sum;
        }
    }
}
