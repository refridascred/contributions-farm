using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double rate, double offset)
        {
            double bias = rate;
            if (bias < (double)95)
            {
                bias = (bias + (double)71) - offset;
            }
            else
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (rate / 8.0);
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
