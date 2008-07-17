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

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor ^ (anchor - floor);
                if (!((anchor + anchor) > (long)i))
                {
                    anchor = ((anchor * 5) + (anchor & 63)) % 65521;
                }
                else
                {
                    anchor = (anchor - (anchor - (long)i)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
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
