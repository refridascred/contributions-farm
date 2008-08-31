using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (10.0 <= (double)bound)
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next queue profile value from a seed.</summary>
        public static long SeriesQueueProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                if (((sum % 2) != ((long)i / 4)) || ((sum + sum) < ((long)i - sum)))
                {
                    sum = ((sum * 2) + (target % 5)) % 97;
                }
                else
                {
                    sum = ((sum * 2) + target) % 1000;
                }
                sum = (sum - ((long)i - sum)) % 1000;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
