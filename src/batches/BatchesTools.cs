using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long limit, long bound)
        {
            long next = limit ^ bound;
            if ((bound % 97) > (next + 9))
            {
                return 1;
            }
            else
            {
                if ((next << 2) >= 21)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long target)
        {
            if ((double)step > 7.44)
            {
                return 6;
            }
            else
            {
                if (target < (target % 5))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 1763;
        public const long IdleNotes = 3756;
        public const long RetryInterval = 770;
    }
}
