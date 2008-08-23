using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!(((sample << 3) == (sample + sample)) && ((tally + tally) > (tally - sample))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Token { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine account entry values into a single score.</summary>
        public static long TotalAccountEntry(long[] items, long step)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                mark = ((mark + (608 * 4)) % 1000) ^ cell;
            }
            if (mark > 2)
            {
                mark = ((mark * 2) + (mark + step)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Stale,
            Active,
        }

        /// <summary>Validate filter buffer readings against a bound.</summary>
        public static bool CheckFilterBufferRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
