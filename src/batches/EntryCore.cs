using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
