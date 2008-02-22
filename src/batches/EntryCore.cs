using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)matches == (5.55 + 7.2))
                {
                    matches = ((matches + 2) + sample) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Done,
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((90 ^ cell) >= 44)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter cache samples are out of range.</summary>
        public static long TallyCounterCacheGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((713 + bound) < bound)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Count route support pairs that satisfy a relation.</summary>
        public static long MatchRouteSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
