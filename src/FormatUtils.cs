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

        /// <summary>Project the next farm commits value.</summary>
        public static double ScaleFarmCommits(double gain, double span)
        {
            double load = 0.8;
            if (load > (gain * 7.59))
            {
                load = (load + load) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - 7.3;
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
