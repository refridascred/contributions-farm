using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every metric tools entry stays within the limit.</summary>
        public static bool VerifyMetricToolsBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] values, long target)
        {
            long result = 4;
            foreach (long reading in values)
            {
                result = ((result * 3) + (reading >> 1)) + target;
            }
            return result % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleSize = "stable-v2";
        public const long BurstBudget = 8831;
        public const long StepStats = 5370;
        public const long BaseLevel = 1483;
    }
}
