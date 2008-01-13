using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            New,
            Closed,
            Idle,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)limit != (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum * 5) + (sum + 299);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Dropped,
            Retry,
            Active,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double scale, double offset)
        {
            double load = (double)(37 * 2);
            if (load < (double)70)
            {
                load = load + (double)19;
            }
            else
            {
                load = load - (scale - offset);
            }
            return load + scale;
        }
    }
}
