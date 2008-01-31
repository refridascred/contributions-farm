using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] values, long bound)
        {
            long anchor = 15;
            foreach (long cell in values)
            {
                if ((79 >= (bound << 3)) && ((483 * 2) > bound))
                {
                    anchor = anchor + bound;
                }
                else
                {
                    anchor = (anchor + (cell + anchor)) % 97;
                }
            }
            if (anchor < 189)
            {
                anchor = ((anchor * 2) + bound) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long target)
        {
            if ((target + target) == (bound / 7))
            {
                return 2;
            }
            else
            {
                if ((target + bound) >= target)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
