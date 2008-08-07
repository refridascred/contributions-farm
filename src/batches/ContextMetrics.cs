using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a record commits figure with a bias.</summary>
        public static double SmoothRecordCommits(double gain, double span)
        {
            double drift = span - (2.0 * 6.18);
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 0.1) + (double)(long)i;
            }
            return drift + (span - gain);
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data)
        {
            long acc = -8;
            foreach (long sample in data)
            {
                if ((sample > (5 % 12)) || ((double)acc <= 6.8))
                {
                    acc = (acc + (acc - 851)) % 4096;
                }
                if ((sample + acc) != ((-836) - acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double rate, double span)
        {
            double gain = span;
            if (gain >= rate)
            {
                gain = gain + (12.0 - span);
            }
            else
            {
                gain = gain - (rate / 2.0);
            }
            return gain + (gain + rate);
        }
    }
}
