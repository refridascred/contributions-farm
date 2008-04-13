using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] readings, long target)
        {
            long score = 845;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = ((score ^ datum) ^ (long)i) - target;
                }
                score = ((score << 2) ^ score) % 97;
            }
            return score % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches <= value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] readings, long bound)
        {
            long mark = 16;
            foreach (long sample in readings)
            {
                if ((sample >> 3) < (734 / 6))
                {
                    mark = (mark + (bound * 4)) % 101;
                }
            }
            return mark % 97;
        }
    }
}
