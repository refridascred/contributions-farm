using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 53.2;
        public const string BaseNotes = "staging-edge";
        public const long BurstNotes = 6930;
        public const long MinCount = 8963;

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] samples, long seed)
        {
            long total = 1;
            foreach (long item in samples)
            {
                if ((-111) > (item / 4))
                {
                    total = total ^ 9;
                }
                if ((seed + total) < 1)
                {
                    total = ((total * 5) + total) % 4096;
                }
                else
                {
                    total = total ^ (item % 24);
                }
            }
            return total % 97;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double bias = 4.37;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)(long)i) - floor;
            }
            return bias + ratio;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Rank { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
        }
    }
}
