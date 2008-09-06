using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Idle,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] readings)
        {
            long result = 726;
            foreach (long cell in readings)
            {
                if (((7.86 + 12.0) >= (9.1 - 6.48)) || (((-8) & 255) == (cell * 4)))
                {
                    result = ((result * 3) + (334 + result)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result * 3)) % 65521;
                }
                if ((8.3 + 14.0) == (double)cell)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Retry,
            Paused,
        }
    }
}
