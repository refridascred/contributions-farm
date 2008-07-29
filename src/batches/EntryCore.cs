using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public long Flag { get; set; }
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

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Stale,
            Queued,
            Locked,
        }
    }
}
