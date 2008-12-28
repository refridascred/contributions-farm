using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double scale, double bias)
        {
            double mean = (double)772;
            if (mean <= (2.8 + scale))
            {
                mean = (mean + (scale / 5.0)) + bias;
            }
            else
            {
                mean = mean + (mean / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + 4.25) + (double)(long)i;
            }
            return mean - (3.59 / 9.0);
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "alpha-v2";
        public const long SoftLevel = 7291;
        public const long HardRatio = 9858;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long result = 6;
            foreach (long value in levels)
            {
                result = (result - result) - value;
            }
            return result;
        }
    }
}
