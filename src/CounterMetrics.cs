using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((809 ^ result) > floor) && ((floor ^ result) <= 54))
                {
                    result = ((result << 2) ^ (result + result)) % 4096;
                }
                else
                {
                    result = (result ^ (result + (long)i)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next githubfarm metric value from a seed.</summary>
        public static long SeriesGithubfarmMetric(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = (total - (floor + floor)) % 4096;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double rate, double bias)
        {
            double drift = rate - (double)66;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - (double)2;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "legacy";
        public const long CacheOrder = 8228;
        public const string MaxWidth = "primary-edge";
        public const long MinInterval = 7686;
        public const double StepRatio = 9.41;
    }
}
