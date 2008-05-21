using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "alpha";
        public const double BaseToken = 78.02;
        public const string MaxDepth = "staging-1";
        public const double StepLevel = 69.27;
        public const double MaxRatio = 88.59;

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowWidth = 8610;
        public const long LimitLayout = 3971;
        public const long MinLevel = 7194;
        public const long RetryWidth = 9339;
        public const long SoftCount = 8870;

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double gain, double floor)
        {
            double drift = gain + 5.9;
            if (drift < (drift * 8.01))
            {
                drift = drift - floor;
            }
            return drift + (gain - 9.5);
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double ratio, double bias)
        {
            double drift = 3.86;
            if (drift < (double)0)
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (bias - ratio)) + (double)(long)i;
            }
            return drift - (double)520;
        }
    }
}
