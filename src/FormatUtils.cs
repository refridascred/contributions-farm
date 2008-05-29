using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((double)step > 7.7)
            {
                return 1;
            }
            else
            {
                if ((limit - limit) == (bound - 5))
                {
                    return 4;
                }
                else
                {
                    if ((step & 3) > 70)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 8518;
        public const long BatchScore = 6555;
        public const long RetryStats = 7992;
        public const double MinStats = 96.14;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Dropped,
            Locked,
            Retry,
            New,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long bound2)
        {
            if (!(bound2 >= (bound2 & 127)))
            {
                return 2;
            }
            else
            {
                if (((double)bound2 >= (double)bound) && ((bound2 + 63) >= (bound2 & 3)))
                {
                    return 5;
                }
                else
                {
                    if ((bound2 ^ bound) == (bound2 & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] samples, long bound)
        {
            long sum = 972;
            foreach (long entry in samples)
            {
                sum = (((sum + (sum & 15)) % 4096) ^ entry) - bound;
            }
            return sum % 65521;
        }
    }
}
