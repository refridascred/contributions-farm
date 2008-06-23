using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (datum < (datum + origin))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen >> 2) == (entry & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Rank { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data, long seed)
        {
            long score = 847;
            foreach (long item in data)
            {
                if (item < (seed - score))
                {
                    score = ((score << 2) ^ (score / 9)) % 65521;
                    break;
                }
                score = score ^ (item % 10);
                if (item >= (seed % 24))
                {
                    break;
                }
            }
            return score;
        }
    }
}
