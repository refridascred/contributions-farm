using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
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

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Active,
            Closed,
            Retry,
        }
    }
}
