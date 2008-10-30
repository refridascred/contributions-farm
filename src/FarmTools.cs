using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardRatio = 4555;
        public const string StepFilter = "alpha-1";
        public const long StepBudget = 7024;
        public const long LimitFilter = 1873;
        public const long WindowFilter = 2850;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Dropped,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
