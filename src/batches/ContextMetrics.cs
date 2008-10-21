using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((count << 2) <= count))
                {
                    count = (count + 3) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit cache counter readings against a rule.</summary>
        public static long CountCacheCounterHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits / 6) == (datum + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
