using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items, long seed)
        {
            long result = 1;
            foreach (long value in items)
            {
                result = ((result - ((long)items.Length + seed)) % 101) - value;
            }
            return result % 65521;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Active,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
