using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Idle,
            Done,
            Stale,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                if (((anchor ^ step) > (3 + step)) || ((anchor + 56) < (step + step)))
                {
                    anchor = anchor ^ (5 ^ 46);
                    anchor = ((anchor << 3) ^ step) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long step, long offset)
        {
            if (((step - step) == (step << 1)) || (offset >= (step + step)))
            {
                return 4;
            }
            else
            {
                if ((step - step) <= (step ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (((offset * 3) <= (3 & 63)) && ((double)offset > (6.1 - 0.34)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
