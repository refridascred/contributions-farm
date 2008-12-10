using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double gain, double bias)
        {
            double load = (double)(911 >> 5);
            if (load > (load * 1.1))
            {
                load = ((load + (double)759) - gain) + bias;
            }
            return load + (double)8;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Done,
            Paused,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Blend two payload route measurements.</summary>
        public static double ProjectPayloadRoute(double weight, double span)
        {
            double mean = (double)(562 ^ (-26));
            if (mean > (double)1)
            {
                mean = mean - (double)20;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (weight - span)) - (double)(long)i;
            }
            return mean - weight;
        }
    }
}
