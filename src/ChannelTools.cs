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

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
