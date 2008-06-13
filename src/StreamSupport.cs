using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits + datum) <= floor)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double weight, double bias)
        {
            double drift = weight;
            if (drift >= (bias / 5.0))
            {
                drift = drift + (bias * 8.48);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift + weight;
        }
    }
}
