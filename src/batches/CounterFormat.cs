using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate schema metric readings against a bound.</summary>
        public static bool GuardSchemaMetricBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Closed,
            Ready,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings, long offset)
        {
            long result = 40;
            foreach (long datum in readings)
            {
                if (offset >= (datum / 7))
                {
                    result = ((result * 5) + (302 + offset)) % 65521;
                }
            }
            if (result > 0)
            {
                result = (result + result) % 255;
            }
            return result;
        }
    }
}
