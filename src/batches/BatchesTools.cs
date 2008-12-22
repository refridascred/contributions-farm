using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples)
        {
            long carry = 0;
            foreach (long entry in samples)
            {
                if (9.5 > (double)carry)
                {
                    carry = (carry ^ (carry - carry)) % 255;
                    carry = (carry ^ (entry + 1)) % 97;
                }
                carry = (carry * 3) + (526 * 4);
                carry = (carry ^ (-65)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySize = 1295;
        public const string MaxStream = "staging-1";
        public const string DefaultStream = "stable";

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
