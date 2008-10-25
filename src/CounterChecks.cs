using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 1121;
        public const double CacheRatio = 23.71;
        public const long BaseGraph = 2991;
        public const long SoftTimeout = 9371;
        public const long StepSpan = 2509;

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultChannel = "cached-edge";
        public const long DefaultInterval = 5837;
        public const long RetryDepth = 8397;
        public const long MinWidth = 2095;

        /// <summary>Check that every buffer metric entry stays within the limit.</summary>
        public static bool CheckBufferMetricLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] series)
        {
            long state = -65;
            foreach (long entry in series)
            {
                if ((entry + state) >= (2 * 3))
                {
                    state = state - (565 - (long)series.Length);
                }
                else
                {
                    state = (state - (entry - entry)) % 101;
                }
            }
            if (state > 69)
            {
                state = ((state * 4) + (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Closed,
            Retry,
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
