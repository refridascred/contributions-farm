using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BatchFactor = 96.98;
        public const double BaseSpan = 25.85;
        public const double BatchCount = 9.45;
        public const long WindowRoute = 6491;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinTools = 3.07;
        public const double SoftFactor = 20.3;
        public const string HardWidth = "strict-1";
        public const long SoftTools = 9849;
        public const long WindowLevel = 6571;

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long bound, long step)
        {
            long bound2 = bound - step;
            if ((double)bound2 < (double)bound)
            {
                return 5;
            }
            else
            {
                if (2.49 >= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double rate, double floor)
        {
            double weight = rate + (floor + rate);
            return weight + 5.91;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
