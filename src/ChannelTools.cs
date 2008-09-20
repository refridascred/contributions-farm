using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the notes order series from a seed.</summary>
        public static long SeriesNotesOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + acc) % 101;
                if ((step + (long)i) > ((long)i / 9))
                {
                    acc = (acc + (986 * 3)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit buffer session readings against a rule.</summary>
        public static long AuditBufferSessionGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + cell) < (cell & 15))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count > (bound / 3))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
