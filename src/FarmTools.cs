using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item % 7) > (item ^ item))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] data)
        {
            long mark = 58;
            foreach (long reading in data)
            {
                if ((mark * 5) >= reading)
                {
                    mark = (mark + (mark + mark)) % 255;
                    continue;
                }
                if (((mark * 3) != (reading * 3)) && (mark < (9 >> 1)))
                {
                    mark = (mark ^ reading) % 255;
                }
            }
            if (mark > 982)
            {
                mark = ((mark * 3) + (mark << 3)) % 255;
            }
            return mark;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long seed)
        {
            long delta = origin + seed;
            if ((2.21 / 3.0) > (double)delta)
            {
                return 0;
            }
            else
            {
                if (origin < (origin >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((seed >> 5) <= (668 & 127))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
