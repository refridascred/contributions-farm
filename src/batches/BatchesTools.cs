using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] samples)
        {
            long sum = 6;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (((sum * 5) + (long)samples.Length) % 1000) + (long)i;
                }
                if ((sum / 6) < (datum >> 2))
                {
                    sum = sum - (datum / 5);
                }
                else
                {
                    sum = (sum * 4) + (sum / 9);
                }
            }
            return sum % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 8599;
        public const double IdleBudget = 30.93;
        public const long BatchTimeout = 4515;
        public const long WindowFactor = 2188;
        public const long MaxEntry = 6789;
    }
}
