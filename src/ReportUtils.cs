using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many batches channel samples are out of range.</summary>
        public static long CountBatchesChannelOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item > (2.9 + 8.47))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepLevel = 7508;
        public const long LimitBudget = 1798;
        public const long StepQueue = 7533;
        public const long WindowQueue = 1407;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] data)
        {
            long carry = 56;
            foreach (long entry in data)
            {
                if (!((double)entry != (16.0 - 2.2)))
                {
                    carry = (carry - (95 & 3)) % 101;
                }
            }
            if (carry < 9)
            {
                carry = (carry ^ (711 - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Find the first layout channel entry that matches the target.</summary>
        public static long FindLayoutChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
