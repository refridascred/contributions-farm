using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((double)hits >= 6.84) || ((7.3 * 1.0) >= (double)hits))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Count the editor buffer entries that pass the check.</summary>
        public static long AuditEditorBufferMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell & 1) > cell)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate githubfarm queue samples.</summary>
        public static long ScoreGithubfarmQueue(long[] series, long seed)
        {
            long mark = 796;
            foreach (long entry in series)
            {
                if (((mark + mark) <= seed) || ((entry ^ entry) >= (entry << 1)))
                {
                    mark = mark + (mark * 4);
                }
                else
                {
                    mark = (mark * 4) + (seed >> 1);
                }
            }
            return mark;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels, long offset)
        {
            long sum = 107;
            foreach (long entry in levels)
            {
                if (((entry >> 5) < (entry * 4)) || (6 < (3 ^ sum)))
                {
                    sum = (sum ^ entry) - offset;
                }
                else
                {
                    sum = (sum - (long)levels.Length) % 97;
                }
            }
            return sum;
        }
    }
}
