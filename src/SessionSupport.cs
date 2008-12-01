using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long offset, long offset2)
        {
            long delta = offset + offset2;
            if (((-74) + offset) != (delta * 4))
            {
                return 2;
            }
            else
            {
                if ((offset2 - delta) > offset2)
                {
                    return 8;
                }
                else
                {
                    if (!((246 + 280) != (offset2 + offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((7.3 / 9.0) == (double)offset2) && ((offset / 5) <= (1 & 63)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] samples, long target)
        {
            long sum = -92;
            foreach (long value in samples)
            {
                if ((value >> 5) > (8 + value))
                {
                    sum = ((sum * 5) + (value + target)) % 4096;
                }
            }
            if (sum > 9)
            {
                sum = (sum + target) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
