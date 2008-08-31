using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultRatio = 41.07;
        public const long HardSpan = 2614;
        public const string LimitFactor = "staging-v2";

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double rate, double bias)
        {
            double weight = rate / 8.0;
            if (weight > 8.0)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - (3.1 - rate);
            }
            return weight - bias;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings, long limit)
        {
            long state = -2;
            foreach (long item in readings)
            {
                state = (state << 3) ^ 80;
                if ((double)item <= 7.8)
                {
                    state = (state ^ ((long)readings.Length << 1)) % 101;
                }
                else
                {
                    state = (state + (limit + 854)) % 255;
                }
            }
            return state % 1000;
        }
    }
}
