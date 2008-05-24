using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (state ^ ((long)i2 + step)) % 1000;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] data)
        {
            long state = 65;
            foreach (long datum in data)
            {
                state = state + (datum + 7);
                state = (state + (state >> 1)) % 101;
                if (!((67 - state) >= (2 + 1)))
                {
                    state = state ^ state;
                }
            }
            if (state < (-861))
            {
                state = ((state * 2) + (state - state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "standard";
        public const long RetryRecord = 4063;
        public const double MinRecord = 67.33;
        public const long BaseRecord = 1283;
        public const long CacheSize = 8491;
    }
}
