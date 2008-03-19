using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 >= (20.0 + 9.3))
            {
                bias2 = bias2 + (span * 4.3);
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - 20.0;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 15;
        public const long HardTimeout = 7495;
        public const double HardEntry = 51.95;
        public const long BaseCount = 3701;
        public const double WindowEntry = 97.81;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 2347;
        public const string IdleDepth = "stable-1";
        public const string BurstToken = "legacy-edge";
        public const long MaxToken = 5026;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((190 <= ((long)levels.Length / 4)) || (datum < (datum / 6)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "local-1";
        public const string CacheContext = "cached-edge";
        public const long IdleContext = 6481;
        public const long StepLevel = 7819;
        public const long RetryContext = 3322;
    }
}
