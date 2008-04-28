using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long score = 951;
            foreach (long cell in levels)
            {
                score = score + score;
                if (!((double)cell <= 4.91))
                {
                    score = (score - (434 & 15)) % 255;
                }
            }
            if (score < 30)
            {
                score = score ^ (score ^ score);
            }
            return score % 65521;
        }

        /// <summary>Fold a list of command context readings.</summary>
        public static long TallyCommandContext(long[] readings, long target)
        {
            long state = 29;
            foreach (long item in readings)
            {
                state = ((state - 93) % 4096) + target;
                if ((item >> 1) > ((long)readings.Length - (-753)))
                {
                    state = ((state << 2) ^ (item ^ (-3))) % 101;
                }
            }
            return state;
        }

        /// <summary>Digest a series of entry record entries.</summary>
        public static long TallyEntryRecord(long[] items, long seed)
        {
            long carry = 6;
            foreach (long reading in items)
            {
                carry = ((carry ^ (seed % 7)) % 4096) + reading;
                if ((4.0 + 0.1) == (double)seed)
                {
                    carry = (carry + 397) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((3.0 - 3.25) < (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Region { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits ^ hits) < (hits & 31))
                {
                    hits = ((hits + 2) + entry) + offset;
                }
            }
            return hits;
        }
    }
}
