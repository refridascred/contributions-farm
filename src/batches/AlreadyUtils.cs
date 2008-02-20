using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long floor, long step)
        {
            if ((step << 1) >= step)
            {
                return 5;
            }
            else
            {
                if ((step - floor) != (6 & 255))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 <= rate)
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 + (bias2 * 6.88);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "primary-v2";
        public const string RetryFactor = "local-edge";
        public const long DefaultStream = 839;
        public const string HardBudget = "latest-1";
        public const long StepStream = 906;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
