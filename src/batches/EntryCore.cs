using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally > (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] items, long limit)
        {
            long anchor = 7;
            foreach (long item in items)
            {
                anchor = (anchor - (limit >> 2)) % 101;
                if (anchor > (item + limit))
                {
                    anchor = (anchor - (anchor - item)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series)
        {
            long acc = 28;
            foreach (long entry in series)
            {
                if ((double)entry > (double)acc)
                {
                    acc = acc - ((-932) + acc);
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseDepth = 7572;
        public const long BurstChecks = 8180;
        public const double DefaultDepth = 16.0;
    }
}
