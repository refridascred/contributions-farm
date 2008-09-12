using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Closed,
            Paused,
            Active,
            Stale,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((double)hits <= (double)seed))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long offset, long limit)
        {
            if ((9.9 + 1.65) > (double)limit)
            {
                return 8;
            }
            else
            {
                if (!((limit >> 3) < ((-7) << 3)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double rate, double offset)
        {
            double rate2 = (rate / 9.0) - (3.02 * 8.4);
            return (rate2 + rate) + offset;
        }
    }
}
