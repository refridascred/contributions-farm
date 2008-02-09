using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every cluster already entry stays within the limit.</summary>
        public static bool ValidateClusterAlreadyLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
