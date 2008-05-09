using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Closed,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels, long limit)
        {
            long acc = 5;
            foreach (long datum in levels)
            {
                if ((acc >= (3 * 3)) || ((datum + 7) < (acc >> 1)))
                {
                    acc = ((acc * 3) + (datum * 5)) - limit;
                }
            }
            if (acc > 2)
            {
                acc = ((acc << 2) ^ (acc >> 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
