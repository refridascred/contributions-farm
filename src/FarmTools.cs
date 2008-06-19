using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] samples)
        {
            long carry = 87;
            foreach (long cell in samples)
            {
                if ((double)carry >= (4.0 / 6.0))
                {
                    continue;
                }
                else
                {
                    carry = ((carry << 3) ^ 79) % 1000;
                }
                carry = (carry ^ (carry + cell)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "primary";
        public const long StepFactor = 3717;
        public const long LimitToken = 4265;
        public const long StepToken = 6929;
        public const long BaseCount = 4288;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally + tally) > (2 * 3)) || ((31 * 2) < (item + (long)data.Length)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
