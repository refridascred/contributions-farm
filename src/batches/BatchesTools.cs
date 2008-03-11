using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] items)
        {
            long mix = 16;
            foreach (long reading in items)
            {
                mix = ((mix << 3) ^ reading) % 65521;
            }
            if (mix < 23)
            {
                mix = ((mix * 2) + (mix ^ mix)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Closed,
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
