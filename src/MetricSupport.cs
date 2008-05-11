using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 5344;
        public const long HardCommand = 8460;
        public const long BatchCommand = 3227;

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

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Ready,
            Stale,
            Queued,
            Dropped,
        }
    }
}
