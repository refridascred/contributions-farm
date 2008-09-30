using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long step2)
        {
            if ((double)step >= (double)5)
            {
                return 3;
            }
            else
            {
                if (step > (89 & 1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate cluster command readings against a bound.</summary>
        public static bool GuardClusterCommandLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
