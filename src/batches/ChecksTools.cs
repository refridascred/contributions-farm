using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double StepInterval = 14.09;
        public const double HardFilter = 51.59;
        public const double BatchFilter = 51.22;
        public const string StepSize = "local";

        /// <summary>Count already batch pairs that satisfy a relation.</summary>
        public static long CompareAlreadyBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of context batches readings.</summary>
        public static long TallyContextBatches(long[] levels)
        {
            long sum = -50;
            foreach (long datum in levels)
            {
                sum = (sum * 5) + datum;
            }
            if (sum < 232)
            {
                sum = (sum + (sum / 7)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
