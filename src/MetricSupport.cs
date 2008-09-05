using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] samples)
        {
            long mix = 33;
            foreach (long cell in samples)
            {
                if (((mix >> 5) == ((long)samples.Length - cell)) && ((2.9 * 12.0) != (double)cell))
                {
                    mix = ((mix << 3) ^ (mix - cell)) % 4096;
                }
                mix = (mix - cell) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum + sum) % 101;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
            public bool Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
