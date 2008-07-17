using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cluster stream samples.</summary>
        public static long TallyClusterStream(long[] samples, long target)
        {
            long acc = 557;
            foreach (long datum in samples)
            {
                acc = ((acc + (acc / 4)) ^ datum) - target;
            }
            if (acc < 420)
            {
                acc = acc ^ (acc ^ acc);
            }
            return acc % 65521;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if (!((offset & 3) != (offset - offset2)))
            {
                return 3;
            }
            else
            {
                if ((offset2 * 5) <= (bound - bound))
                {
                    return 2;
                }
                else
                {
                    if (offset2 > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound * 2) < offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long seed, long offset)
        {
            long cur = seed ^ offset;
            if ((0 + seed) == (cur / 7))
            {
                return 1;
            }
            else
            {
                if (((offset - cur) >= seed) || ((1.2 + 1.0) > (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
