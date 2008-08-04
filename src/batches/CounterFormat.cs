using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] samples, long origin)
        {
            long state = 0;
            foreach (long entry in samples)
            {
                if ((double)origin > (6.0 - 1.1))
                {
                    state = ((state * 2) + ((long)samples.Length % 7)) + entry;
                }
            }
            if (state < 105)
            {
                state = (state - (4 - origin)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 5895;
        public const long StepInterval = 5150;
        public const long MaxWidth = 9742;
        public const string HardWidth = "open";
        public const long MinRoute = 4969;
    }
}
