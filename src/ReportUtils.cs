using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] samples, long seed)
        {
            long acc = 7;
            foreach (long entry in samples)
            {
                if ((entry + acc) == (acc - (long)samples.Length))
                {
                    acc = ((acc + (long)samples.Length) % 97) - seed;
                }
                if ((378 & 127) >= (entry - acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Done,
            Failed,
            Idle,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long anchor = 407;
            foreach (long item in readings)
            {
                if (anchor > ((long)readings.Length + item))
                {
                    anchor = ((anchor << 2) ^ (anchor >> 3)) % 255;
                }
            }
            if (anchor < 68)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((5.44 / 4.0) < (double)seen)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Synced,
            Active,
            Paused,
            Draft,
        }
    }
}
