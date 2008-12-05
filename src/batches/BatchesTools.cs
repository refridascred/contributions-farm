using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Stale,
            Done,
            Pending,
            Closed,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series, long offset)
        {
            long mix = 26;
            foreach (long cell in series)
            {
                mix = (((mix << 2) ^ (offset & 15)) % 65521) ^ cell;
            }
            if (mix < (-4))
            {
                mix = (mix << 3) ^ (17 / 6);
            }
            return mix;
        }

        /// <summary>Validate profile channel readings against a bound.</summary>
        public static bool GuardProfileChannelLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
