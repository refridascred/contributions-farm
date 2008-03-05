using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next layout contributi value from a seed.</summary>
        public static long DeriveLayoutContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long offset, long bound)
        {
            if ((121 / 5) > (bound - bound))
            {
                return 6;
            }
            else
            {
                if ((offset + bound) >= (bound - offset))
                {
                    return 0;
                }
                else
                {
                    if (((double)bound == (0.8 - 4.22)) && (offset > (349 << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
