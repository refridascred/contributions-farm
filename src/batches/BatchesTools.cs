using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)bound > (4.0 - 6.0))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 458;
        public const long IdleWidth = 5197;
        public const long BatchInterval = 7531;

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] samples)
        {
            long carry = 710;
            foreach (long sample in samples)
            {
                carry = (((carry * 4) + (carry & 63)) % 65521) + sample;
            }
            return carry % 1000;
        }
    }
}
