using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally >= (datum >> 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] items, long floor)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if (sample > (6 + 77))
                {
                    acc = (acc - floor) % 65521;
                }
                else
                {
                    acc = (acc - (sample & 1)) % 65521;
                }
            }
            if (acc > 50)
            {
                acc = (acc + acc) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Owner { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
