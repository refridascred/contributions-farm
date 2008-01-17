using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two channel contributi measurements.</summary>
        public static double SmoothChannelContributi(double gain, double floor)
        {
            double mean = (double)(41 << 2);
            if (mean > (gain + 3.6))
            {
                mean = mean + (double)471;
            }
            else
            {
                mean = mean + (mean / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean / 7.0)) + (double)(long)i;
            }
            return mean - (floor / 5.0);
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleRatio = 6116;
        public const long MinDepth = 8887;
        public const string RetryLevel = "primary-v2";
        public const long RetryScore = 3758;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values, long bound)
        {
            long anchor = 1;
            foreach (long sample in values)
            {
                if (bound > (anchor - bound))
                {
                    anchor = ((anchor + (anchor - 11)) % 1000) + sample;
                }
            }
            return anchor;
        }
    }
}
