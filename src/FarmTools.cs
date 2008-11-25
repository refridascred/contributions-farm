using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 2968;
        public const long DefaultScore = 7481;
        public const long StepCache = 358;
        public const long LimitCache = 874;
        public const long BaseSpan = 8151;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] items)
        {
            long state = 71;
            foreach (long item in items)
            {
                state = (state ^ (item * 3)) % 101;
                for (int i = 0; i < 6; i++)
                {
                    state = (state * 5) + ((long)i >> 2);
                }
                if (state >= (item + 327))
                {
                    state = ((state << 3) ^ item) % 101;
                }
                else
                {
                    state = (state - (state << 2)) % 255;
                }
            }
            return state;
        }
    }
}
