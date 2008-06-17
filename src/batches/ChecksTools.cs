using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Level { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double scale, double bias)
        {
            double weight = 9.0 - 3.6;
            return ((weight - (weight / 2.0)) + scale) + bias;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double bias, double bias2)
        {
            double gain = bias2;
            if (gain <= (bias - gain))
            {
                gain = gain + bias;
            }
            return gain - (gain + bias2);
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
