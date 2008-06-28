using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                long bound = target + ((long)i - sum);
                if (sum <= target)
                {
                    sum = sum + 69;
                }
                else
                {
                    sum = ((sum * 5) + ((long)i ^ bound)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
