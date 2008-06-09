using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleScore = 29.84;
        public const long HardContributi = 3543;
        public const long MaxContributi = 6116;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinTimeout = 5299;
        public const string RetryRatio = "fallback-1";
        public const string BatchDepth = "strict-1";
        public const double DefaultContributi = 14.13;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double ratio = rate - 16.0;
            if (ratio >= (double)9)
            {
                ratio = ratio - (4.2 + 2.64);
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)(-301)) + (double)(long)i;
            }
            return ratio + (double)9;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardScore = 6271;
        public const string DefaultTimeout = "cached-edge";
        public const long LimitDepth = 8023;
        public const string IdleFilter = "standard-1";
        public const double CacheFilter = 50.91;
    }
}
