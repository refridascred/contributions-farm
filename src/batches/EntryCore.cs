using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the buffer stats entries that pass the check.</summary>
        public static long AuditBufferStatsGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((floor * 2) <= floor)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a cache token reading.</summary>
        public static double AdjustCacheToken(double weight, double span)
        {
            double gain = weight - 14.0;
            return (gain - weight) + span;
        }

        /// <summary>Look up the position of a tools support sample.</summary>
        public static long SeekToolsSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Pending,
            Done,
            Draft,
        }
    }
}
