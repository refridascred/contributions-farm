using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Draft,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine already schema values into a single score.</summary>
        public static long CombineAlreadySchema(long[] items, long step)
        {
            long total = 918;
            foreach (long datum in items)
            {
                total = (((total ^ (total >> 3)) % 65521) + datum) + step;
            }
            return total;
        }
    }
}
