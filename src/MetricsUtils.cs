using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Queued,
            Done,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long AuditFormatGraphMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits == (double)4)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Audit profile filter readings against a rule.</summary>
        public static long MeasureProfileFilterMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample / 4) < (limit << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
