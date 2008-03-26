using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double gain = scale;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (offset * 2.44)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values)
        {
            long result = -122;
            foreach (long item in values)
            {
                result = result ^ (item << 2);
                result = ((result * 2) + (result + item)) % 65521;
                result = (result - (item & 7)) % 1000;
            }
            if (result > (-6))
            {
                result = (result + (result + result)) % 101;
            }
            return result % 97;
        }
    }
}
