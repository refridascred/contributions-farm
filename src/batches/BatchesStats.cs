using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings)
        {
            long mark = 8;
            foreach (long entry in readings)
            {
                mark = ((mark << 2) ^ mark) - entry;
            }
            return mark % 65521;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long sum = 50;
            foreach (long reading in levels)
            {
                if (!(offset < 100))
                {
                    sum = (sum + (732 + offset)) % 4096;
                }
                else
                {
                    sum = sum - (reading + offset);
                }
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchRatio = 49.96;
        public const long RetryRatio = 2156;
        public const long SoftLevel = 3502;
    }
}
