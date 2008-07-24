using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Ready,
            Retry,
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double scale, double offset)
        {
            double rate = (offset / 9.0) + scale;
            return rate + (rate - offset);
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Region { get; set; }
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((12.0 + 9.1) > (double)datum)
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Count the contributi cluster entries that pass the check.</summary>
        public static long TallyContributiClusterMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count * 4) >= (count + count))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
