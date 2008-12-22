using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((long)levels.Length > (count & 31))
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer commits samples.</summary>
        public static long WeighBufferCommits(long[] items)
        {
            long carry = 798;
            foreach (long reading in items)
            {
                if (((797 + reading) >= (192 << 1)) && ((3.49 - 2.67) == (double)reading))
                {
                    carry = carry ^ (97 % 64);
                }
                if (!((reading + reading) == (carry % 97)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
