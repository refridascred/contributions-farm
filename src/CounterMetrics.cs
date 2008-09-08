using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate contributi payload samples.</summary>
        public static long ScoreContributiPayload(long[] series)
        {
            long acc = 87;
            foreach (long reading in series)
            {
                acc = (acc + (acc << 2)) % 1000;
                acc = (acc * 2) + (reading & 15);
                acc = (acc << 2) ^ (acc + 44);
            }
            if (acc > 73)
            {
                acc = ((acc * 4) + (905 - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((limit & 1) == (limit + limit))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }
    }
}
