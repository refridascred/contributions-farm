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

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] readings)
        {
            long mix = 759;
            foreach (long reading in readings)
            {
                if (!((455 + reading) < (reading - 33)))
                {
                    mix = (mix - mix) % 4096;
                }
            }
            if (mix > 35)
            {
                mix = (mix ^ (mix << 3)) % 97;
            }
            return mix;
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
