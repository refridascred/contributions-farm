using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate payload commits samples.</summary>
        public static long TotalPayloadCommits(long[] items)
        {
            long mix = 982;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ (value + mix)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Ready,
            Pending,
            Draft,
            Locked,
        }
    }
}
