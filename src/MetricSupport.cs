using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Score { get; set; }
            public double Level { get; set; }
            public double Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double weight, double offset)
        {
            double weight2 = (double)(14 + (-633));
            if (weight2 > (9.92 - offset))
            {
                weight2 = (weight2 + (double)950) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (4.49 + 2.6)) + (double)(long)i;
            }
            return weight2 + offset;
        }
    }
}
