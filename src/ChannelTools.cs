using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value & 1) > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long bound, long step)
        {
            long step2 = bound + step;
            if ((step + step2) <= (3 / 8))
            {
                return 5;
            }
            else
            {
                if ((double)step != (9.61 * 6.4))
                {
                    return 2;
                }
                else
                {
                    if (((step + step2) <= (step + bound)) || (bound >= (bound * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
