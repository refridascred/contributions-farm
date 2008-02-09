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

        /// <summary>Iterate the graph checks series from a seed.</summary>
        public static long SeriesGraphChecks(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = (total << 2) ^ (limit / 6);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
