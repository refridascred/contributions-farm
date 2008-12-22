using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next commits metrics value.</summary>
        public static double ProjectCommitsMetrics(double bias, double span)
        {
            double ratio = (double)(386 & 1);
            if (ratio <= (ratio - bias))
            {
                ratio = (ratio + bias) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio / 6.0)) - (double)(long)i;
            }
            return ratio - (bias * 7.0);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
