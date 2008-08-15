using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long seed, long offset)
        {
            long edge = seed - offset;
            if ((double)offset < (2.0 * 9.3))
            {
                return 1;
            }
            else
            {
                if ((double)seed != (double)87)
                {
                    return 7;
                }
                else
                {
                    if (((offset + offset) != (edge >> 5)) || ((seed / 8) > (offset & 127)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)sample > (7.0 / 6.0))
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] readings)
        {
            long total = 45;
            foreach (long value in readings)
            {
                if (((74 >> 1) <= value) && ((value >> 5) < total))
                {
                    total = ((total * 2) + value) % 101;
                }
            }
            return total;
        }
    }
}
