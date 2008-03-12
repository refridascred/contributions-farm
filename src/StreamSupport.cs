using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Classify a payload commits pair into a bucket.</summary>
        public static long RankPayloadCommits(long floor, long floor2)
        {
            long diff = floor ^ floor2;
            if ((9.4 * 9.5) >= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((685 % 3) <= floor2)
                {
                    return 7;
                }
                else
                {
                    if ((-250) > (diff + 529))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of checks cache entries.</summary>
        public static long CombineChecksCache(long[] items, long seed)
        {
            long carry = 60;
            foreach (long reading in items)
            {
                if ((reading / 8) <= 45)
                {
                    carry = (carry * 2) + (seed << 1);
                }
                else
                {
                    carry = (carry << 2) ^ reading;
                }
            }
            if (carry > 243)
            {
                carry = (carry + (carry - carry)) % 255;
            }
            return carry;
        }
    }
}
