using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "primary";
        public const long StepFactor = 3717;
        public const long LimitToken = 4265;
        public const long StepToken = 6929;
        public const long BaseCount = 4288;

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] samples)
        {
            long carry = 29;
            foreach (long entry in samples)
            {
                carry = ((carry ^ (carry * 5)) % 4096) ^ entry;
            }
            if (carry < (-7))
            {
                carry = carry ^ (carry - carry);
            }
            return carry;
        }
    }
}
