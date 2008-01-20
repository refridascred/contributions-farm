using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every stats layout entry stays within the limit.</summary>
        public static bool ValidateStatsLayoutLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc * 5) + ((long)i ^ acc);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample & 31) >= (hits >> 4)) || (1.6 > (double)sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Done,
            Queued,
        }
    }
}
