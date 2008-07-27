using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Stale,
            Retry,
            New,
            Closed,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] items)
        {
            long score = 5;
            foreach (long datum in items)
            {
                if (((score << 1) == ((-83) / 3)) || ((8.0 * 5.93) >= (double)score))
                {
                    score = (((score << 3) ^ 478) % 4096) + datum;
                }
            }
            return score;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample - origin) == (248 - 75))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Synced,
            Active,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long anchor = -704;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (anchor << 3) ^ (long)i;
                }
                if (anchor <= (value + anchor))
                {
                    anchor = ((anchor * 3) + (anchor % 5)) % 4096;
                }
            }
            return anchor;
        }
    }
}
