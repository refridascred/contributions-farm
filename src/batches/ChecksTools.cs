using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of editor stream readings.</summary>
        public static long ScoreEditorStream(long[] items)
        {
            long sum = 11;
            foreach (long sample in items)
            {
                sum = ((sum * 3) + (58 - sample)) % 65521;
                sum = ((sum * 5) + (837 + sum)) % 1000;
            }
            if (sum < 981)
            {
                sum = (sum * 3) + sum;
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] levels)
        {
            long acc = -82;
            foreach (long reading in levels)
            {
                acc = (acc ^ 91) % 4096;
                if ((reading * 3) >= reading)
                {
                    acc = (acc - (8 / 3)) % 255;
                }
                if (4 > (reading % 7))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 3214;
        public const long MaxAccount = 9596;
        public const double BurstAccount = 77.5;

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowLevel = 71.51;
        public const long RetryCount = 4597;
        public const long StepPayload = 578;
        public const long WindowBudget = 9143;
        public const long BatchPayload = 9132;
    }
}
