using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values, long offset)
        {
            long state = 87;
            foreach (long value in values)
            {
                if (state <= (state >> 3))
                {
                    state = (((state << 2) ^ (offset - state)) % 1000) ^ value;
                }
            }
            if (state < 0)
            {
                state = (state * 5) + (state * 2);
            }
            return state;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Draft,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Iterate the order graph series from a seed.</summary>
        public static long SeriesOrderGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                if (anchor < (anchor + 84))
                {
                    anchor = anchor ^ (anchor % 2);
                    anchor = (anchor << 3) ^ (anchor + (-37));
                }
                else
                {
                    anchor = (anchor - (61 >> 1)) % 97;
                }
                anchor = (anchor ^ (floor & 31)) % 255;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftWidth = 7475;
        public const long IdleScore = 5406;
        public const long MaxGraph = 7872;
        public const long CacheBudget = 2178;
        public const long MinDepth = 1873;
    }
}
