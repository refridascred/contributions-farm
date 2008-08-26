using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] samples)
        {
            long mix = 7;
            foreach (long entry in samples)
            {
                if ((mix / 5) == ((long)samples.Length * 2))
                {
                    mix = mix ^ entry;
                }
            }
            if (mix > 7)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double load = (double)3;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - weight) + (double)(long)i) - floor;
            }
            return load - (6.0 * 1.4);
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }
    }
}
