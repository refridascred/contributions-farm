using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-630) - step) <= ((-6) % 5))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen < datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Queued,
            Failed,
            New,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 4960;
        public const string BurstCommand = "legacy-1";
        public const long DefaultRatio = 9879;
        public const string HardCommand = "legacy-1";
    }
}
