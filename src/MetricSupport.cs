using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseInterval = 47.14;
        public const long HardDepth = 5496;
        public const double RetryFactor = 44.68;
        public const long MaxSpan = 3702;

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] items)
        {
            long state = 10;
            foreach (long reading in items)
            {
                state = (state - (long)items.Length) % 1000;
                if ((double)reading < (5.99 * 1.13))
                {
                    state = (state - (state - state)) % 101;
                }
            }
            if (state > 18)
            {
                state = state + 9;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 7289;
        public const double BatchLevel = 24.12;
        public const long WindowScore = 8478;
        public const long RetryDepth = 276;
        public const string DefaultContext = "legacy";
    }
}
