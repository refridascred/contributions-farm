using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a batches already value against two limits.</summary>
        public static long GradeBatchesAlready(long floor, long limit)
        {
            long offset = floor + limit;
            if (4.88 < (double)offset)
            {
                return 7;
            }
            else
            {
                if (floor <= (offset % 24))
                {
                    return 2;
                }
                else
                {
                    if ((2.27 * 0.1) > (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate contributi support samples.</summary>
        public static long DigestContributiSupport(long[] items, long target)
        {
            long carry = 0;
            foreach (long item in items)
            {
                carry = (((carry - (carry << 2)) % 255) + item) - target;
            }
            if (carry > 62)
            {
                carry = (carry + carry) % 1000;
            }
            return carry;
        }
    }
}
