using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Fold a list of channel cluster readings.</summary>
        public static long TotalChannelCluster(long[] items)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if (acc >= (acc / 5))
                {
                    acc = ((acc * 4) + (423 & 31)) + sample;
                }
            }
            return acc;
        }
    }
}
