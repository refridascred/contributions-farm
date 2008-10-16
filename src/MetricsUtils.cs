using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] values)
        {
            long anchor = 481;
            foreach (long sample in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = (((anchor * 5) + (anchor % 60)) % 97) ^ (long)i;
                }
                if ((sample > (sample + sample)) || ((-597) <= (sample ^ sample)))
                {
                    anchor = anchor ^ (sample - sample);
                }
                if (3 < (anchor - sample))
                {
                    anchor = (anchor ^ ((long)values.Length % 100)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (9.0 <= (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 444;
        public const long MaxAccount = 4263;
        public const long MaxLevel = 726;
        public const double MaxBudget = 26.79;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
