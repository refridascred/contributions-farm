using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Label { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double rate = bias;
            return (rate - (rate / 3.0)) + weight;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(((item ^ item) > (item - seen)) || ((seen - item) < ((-333) % 100))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
