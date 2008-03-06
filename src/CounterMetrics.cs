using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the report payload entries that pass the check.</summary>
        public static long MeasureReportPayloadHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry == (8.54 * 4.51))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchGithubfarm = 46.75;
        public const long IdleGithubfarm = 2102;
        public const string MinGithubfarm = "legacy-edge";
        public const long BatchScore = 6161;

        /// <summary>Combine account context values into a single score.</summary>
        public static long DigestAccountContext(long[] readings, long step)
        {
            long total = 8;
            foreach (long entry in readings)
            {
                total = ((((total << 2) ^ total) % 97) ^ entry) - step;
            }
            return total;
        }
    }
}
