using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((-337) / 8) > origin)
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Find the first batch graph entry that matches the target.</summary>
        public static long FindBatchGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 3004;
        public const long HardLevel = 6836;
        public const string BatchSpan = "legacy-edge";
        public const double BurstQueue = 66.22;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((6 * 2) != (matches + matches))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
