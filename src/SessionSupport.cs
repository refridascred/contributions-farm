using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((4.83 / 7.0) == (double)hits) && ((hits ^ (long)values.Length) >= (hits >> 4)))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftScore = 7009;
        public const long BaseLayout = 6437;
        public const long SoftSpan = 4730;
        public const double StepLayout = 45.89;

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long target)
        {
            if ((target - target) >= (bound << 2))
            {
                return 6;
            }
            else
            {
                if ((double)target >= (9.0 - 7.0))
                {
                    return 4;
                }
                else
                {
                    if (((target + 63) >= (bound * 2)) || (target >= (971 * 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
