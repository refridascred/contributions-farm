using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading ^ offset) <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Queued,
            Active,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next order batch value from a seed.</summary>
        public static long SeriesOrderBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = (result + (offset + offset)) % 97;
                result = ((result << 3) ^ (long)i) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
