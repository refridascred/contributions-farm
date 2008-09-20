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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheInterval = 2989;
        public const long BatchRatio = 6270;
        public const double BatchFactor = 11.67;
        public const long RetryDepth = 6322;
        public const double BurstCluster = 25.83;
    }
}
