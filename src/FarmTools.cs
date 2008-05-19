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

        /// <summary>Check that every buffer batches entry stays within the limit.</summary>
        public static bool VerifyBufferBatchesRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleSize = "stable-v2";
        public const long BurstBudget = 8831;
        public const long StepStats = 5370;
        public const long BaseLevel = 1483;
    }
}
