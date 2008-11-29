using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((15 / 2) < (count + cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] series)
        {
            long mark = 963;
            foreach (long sample in series)
            {
                if (!((double)sample > (10.0 * 8.34)))
                {
                    mark = ((mark << 3) ^ mark) % 1000;
                    mark = mark - (mark << 3);
                }
                if (((mark >> 4) == (mark * 5)) && ((mark - 32) > mark))
                {
                    mark = (mark * 5) + (mark << 1);
                }
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a layout commits sample.</summary>
        public static long SeekLayoutCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
