using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next order metric value.</summary>
        public static double BlendOrderMetric(double bias, double floor)
        {
            double bias2 = 9.26;
            if (bias2 < bias2)
            {
                bias2 = (bias2 - 8.0) + bias;
            }
            else
            {
                bias2 = bias2 - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 + 4.0;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Look up the position of a already route sample.</summary>
        public static long LookupAlreadyRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command metrics readings against a bound.</summary>
        public static bool VerifyCommandMetricsBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
