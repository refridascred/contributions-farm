using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((-81) + mark) <= bound)
                {
                    mark = (mark - (mark + bound)) % 65521;
                }
                else
                {
                    mark = (mark - bound) % 4096;
                    mark = mark + mark;
                }
                mark = (mark ^ (10 << 3)) % 97;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long target)
        {
            long span = seed - target;
            if ((target >> 1) > span)
            {
                return 2;
            }
            else
            {
                if (!((double)seed > 8.9))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
