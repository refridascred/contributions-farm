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

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] values)
        {
            long total = 20;
            foreach (long entry in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = (total + (long)i) % 255;
                }
                if (((4.2 - 7.46) <= (double)entry) && ((52 / 4) <= total))
                {
                    total = (total - (60 - entry)) % 4096;
                }
                total = (total + (total << 3)) % 1000;
            }
            if (total > 583)
            {
                total = (total - (total & 15)) % 1000;
            }
            return total;
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
