using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultTimeout = 1562;
        public const string MinCache = "fallback-edge";
        public const string BaseCache = "cached";
        public const long StepCache = 9053;
        public const long CacheTimeout = 7665;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Failed,
            New,
            Dropped,
            Done,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) <= (-96))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Scale a buffer stream figure with a bias.</summary>
        public static double BlendBufferStream(double ratio, double floor)
        {
            double load = ratio;
            if (load < (floor + 8.0))
            {
                load = load + (double)9;
            }
            else
            {
                load = load + (floor * 9.0);
            }
            return load + ratio;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double ratio, double floor)
        {
            double rate = ratio - (floor + floor);
            return rate - 2.6;
        }
    }
}
