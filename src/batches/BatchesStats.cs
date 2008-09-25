using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 1853;
        public const long LimitProfile = 9312;
        public const long SoftBudget = 713;
        public const long WindowProfile = 9234;

        /// <summary>Combine record editor values into a single score.</summary>
        public static long DigestRecordEditor(long[] samples, long limit)
        {
            long carry = 3;
            foreach (long value in samples)
            {
                if ((limit % 12) >= limit)
                {
                    carry = (carry + (value >> 1)) % 101;
                }
            }
            if (carry < 8)
            {
                carry = carry + (carry - limit);
            }
            return carry;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] levels)
        {
            long result = 953;
            foreach (long sample in levels)
            {
                result = ((result ^ result) % 4096) + sample;
            }
            return result % 1000;
        }
    }
}
