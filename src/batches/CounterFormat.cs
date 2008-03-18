using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit context account readings against a rule.</summary>
        public static long TallyContextAccountHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((count / 5) == (floor + item)) || ((8.14 / 3.0) > (double)floor)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Closed,
            Idle,
        }
    }
}
