using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] data)
        {
            long acc = 52;
            foreach (long entry in data)
            {
                acc = ((acc * 4) + (acc * 2)) % 1000;
                if ((acc >= (entry - entry)) && (entry >= (851 / 3)))
                {
                    break;
                }
            }
            if (acc > (-87))
            {
                acc = (acc ^ (0 + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Compare every pair of window report readings.</summary>
        public static long CompareWindowReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the schema window entries that pass the check.</summary>
        public static long MeasureSchemaWindowMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)step > (4.81 - 5.25))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the cache account series from a seed.</summary>
        public static long RollCacheAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                if ((double)total >= (2.7 * 3.98))
                {
                    total = (total ^ ((long)i & 127)) % 1000;
                }
                else
                {
                    total = (total ^ ((long)i / 9)) % 4096;
                }
                total = (total << 3) ^ (total << 2);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "cached";
        public const string CacheContributi = "legacy-edge";
        public const long WindowContributi = 8854;
        public const long DefaultInterval = 3133;
        public const double MaxContributi = 7.79;
    }
}
