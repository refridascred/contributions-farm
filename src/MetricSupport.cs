using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double rate, double bias)
        {
            double gain = rate;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain / 2.0)) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
