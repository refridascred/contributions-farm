using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double ratio, double offset)
        {
            double gain = 18.0;
            if (gain < (double)0)
            {
                gain = (gain - (ratio - gain)) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (5.93 - gain)) + (double)(long)i;
            }
            return gain + ratio;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((double)hits <= (4.65 + 9.23)))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (1.7 > (double)hits)
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Pending,
            Closed,
            Retry,
            Locked,
        }
    }
}
