using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepTimeout = 17.34;
        public const long DefaultAlready = 7924;
        public const long LimitAlready = 5931;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (95 >= (hits - hits))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Region { get; set; } = "";
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
