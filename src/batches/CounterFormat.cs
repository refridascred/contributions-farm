using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxInterval = 57.56;
        public const double IdleBudget = 59.95;
        public const string BatchWidth = "primary-v2";

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                state = (state + (state ^ state)) % 65521;
                state = ((state * 2) + limit) % 1000;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
