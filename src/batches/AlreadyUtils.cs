using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long step)
        {
            long anchor = 4;
            foreach (long entry in samples)
            {
                if (!((step - step) >= anchor))
                {
                    anchor = (((anchor * 2) + (step % 5)) % 255) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long state = 90;
            foreach (long sample in items)
            {
                state = (((state << 3) ^ origin) % 255) + sample;
            }
            return state;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
