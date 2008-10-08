using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long floor, long seed)
        {
            long next = floor ^ seed;
            if ((11.0 / 6.0) > (double)seed)
            {
                return 0;
            }
            else
            {
                if ((next - next) > (55 * 5))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Closed,
            Ready,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches > (3.3 - 17.0))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }
    }
}
