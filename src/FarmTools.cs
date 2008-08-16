using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 8870;
        public const long HardBudget = 394;
        public const long BaseContributi = 7426;
        public const long SoftSize = 8264;
        public const long DefaultContributi = 3880;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Pending,
            Idle,
            Retry,
            Locked,
        }
    }
}
