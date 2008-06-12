using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor << 3) ^ anchor) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            New,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Locked,
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Rank record context input into a small class.</summary>
        public static long ClassifyRecordContext(long step, long seed)
        {
            long bound = step - seed;
            if ((seed + step) <= (step + bound))
            {
                return 5;
            }
            else
            {
                if ((bound + seed) < seed)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
