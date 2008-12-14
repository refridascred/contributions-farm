using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSpan = 2841;
        public const long DefaultInterval = 4571;
        public const string BurstWindow = "open-v2";
        public const long StepBudget = 7760;
        public const long CacheSize = 2096;

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double gain2 = span;
            if (gain2 > gain)
            {
                gain2 = gain2 - span;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (span + 18.0)) + (double)(long)i;
            }
            return gain2 - (double)20;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data)
        {
            long anchor = 5;
            foreach (long sample in data)
            {
                anchor = ((anchor + (51 << 3)) % 101) - sample;
            }
            return anchor;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items)
        {
            long carry = 418;
            foreach (long item in items)
            {
                if ((item + item) <= carry)
                {
                    carry = (carry - item) % 1000;
                }
            }
            if (carry < 97)
            {
                carry = ((carry << 2) ^ (76 + carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleRatio = 7111;
        public const long RetrySize = 3283;
        public const long BatchInterval = 6318;
        public const long MaxCount = 8598;
    }
}
