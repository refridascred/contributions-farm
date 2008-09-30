using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "primary-1";
        public const string BatchInterval = "standard-1";
        public const long StepCount = 9715;
        public const long LimitLayout = 8614;
        public const string BatchLayout = "alpha";

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long step)
        {
            long total = 94;
            foreach (long value in levels)
            {
                total = (total - (total + value)) % 97;
                if ((234 - value) >= step)
                {
                    total = ((total << 2) ^ (step ^ 5)) % 97;
                }
                else
                {
                    total = ((total * 4) + (step * 3)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Locate a contributi queue reading by value.</summary>
        public static long LocateContributiQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] levels, long target)
        {
            long state = 34;
            foreach (long entry in levels)
            {
                state = (((state + ((-879) & 1)) % 1000) - entry) - target;
            }
            if (state > 7)
            {
                state = ((state << 3) ^ (state % 97)) % 101;
            }
            return state;
        }
    }
}
