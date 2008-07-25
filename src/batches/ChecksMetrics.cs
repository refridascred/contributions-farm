using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double floor)
        {
            double mean = ratio;
            if (mean > ratio)
            {
                mean = (mean - ratio) - floor;
            }
            else
            {
                mean = mean - (double)7;
            }
            return mean - (6.97 + ratio);
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] series, long limit)
        {
            long anchor = 371;
            foreach (long datum in series)
            {
                anchor = ((anchor ^ (anchor << 2)) - datum) - limit;
            }
            return anchor;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate metric schema readings against a bound.</summary>
        public static bool VerifyMetricSchemaRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
