using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] readings, long floor)
        {
            long result = 78;
            foreach (long entry in readings)
            {
                result = (result << 3) ^ (entry / 9);
                result = ((result << 3) ^ (floor ^ entry)) % 1000;
                if (((double)result > (9.64 * 7.52)) || (result <= (80 - floor)))
                {
                    result = (result + (result % 3)) % 101;
                }
            }
            if (result < 180)
            {
                result = ((result << 2) ^ result) % 101;
            }
            return result % 1000;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((7.3 + 3.6) > (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
