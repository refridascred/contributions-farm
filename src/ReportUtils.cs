using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the session payload entries that pass the check.</summary>
        public static long MeasureSessionPayloadHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((entry >> 3) != (entry ^ 82)) || (((0.35 / 6.0) < (double)entry) || ((double)target < (3.9 + 2.5))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((((seed % 97) > ((long)data.Length & 3)) || ((8.0 - 0.03) < (9.6 - 1.4))) || (((17.0 / 9.0) <= (double)count) || (((-537) >> 4) >= seed)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Count the command schema entries that pass the check.</summary>
        public static long MeasureCommandSchemaOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((15.0 * 2.7) == (double)value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
