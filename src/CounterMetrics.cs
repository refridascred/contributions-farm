using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] series)
        {
            long state = 269;
            foreach (long entry in series)
            {
                state = ((state - (state / 9)) % 255) + entry;
            }
            if (state < 9)
            {
                state = (state + (0 + state)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 3723;
        public const long LimitLevel = 6058;
        public const string BaseFactor = "standard";
        public const string MaxScore = "standard-v2";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item > (item & 255))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
