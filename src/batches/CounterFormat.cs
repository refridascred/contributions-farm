using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 2820;
        public const double LimitProfile = 9.81;
        public const string BatchProfile = "fallback";
        public const double MinProfile = 91.46;
        public const string RetryTimeout = "cached-edge";

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long target, long bound)
        {
            if (((target ^ 21) == (target - bound)) || (4.46 < (double)target))
            {
                return 7;
            }
            else
            {
                if (target > (-64))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
