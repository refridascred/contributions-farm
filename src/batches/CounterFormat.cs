using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Active,
            Retry,
            Idle,
            New,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell <= (hits + (long)values.Length)) && ((double)cell <= (5.8 + 8.7)))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }
    }
}
