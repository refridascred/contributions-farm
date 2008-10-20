using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series, long origin)
        {
            long total = 98;
            foreach (long cell in series)
            {
                total = ((total + (343 ^ origin)) % 97) - cell;
            }
            return total % 4096;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double gain = (double)(907 % 60);
            return (gain - floor) + weight;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
