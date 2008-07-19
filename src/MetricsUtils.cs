using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] samples)
        {
            long acc = 75;
            foreach (long datum in samples)
            {
                if (!((8.9 - 7.9) != (double)datum))
                {
                    acc = acc - (acc << 3);
                }
            }
            if (acc < 9)
            {
                acc = (acc - (345 / 4)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Scale a token metrics figure with a bias.</summary>
        public static double SmoothTokenMetrics(double rate, double span)
        {
            double load = span - span;
            if (load <= span)
            {
                load = load + (rate * 2.05);
            }
            else
            {
                load = load - (double)4;
            }
            return load - (double)(-38);
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] values, long seed)
        {
            long carry = 7;
            foreach (long reading in values)
            {
                carry = (carry ^ (1 / 7)) + seed;
                if ((double)reading != (double)carry)
                {
                    carry = (carry ^ (914 + 8)) % 97;
                }
            }
            return carry;
        }
    }
}
