using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count schema queue pairs that satisfy a relation.</summary>
        public static long MatchSchemaQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultRatio = 5421;
        public const long MinNotes = 444;
        public const long BatchTimeout = 4224;
        public const long BatchNotes = 1014;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!!((floor - count) > (count / 7)))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }
    }
}
