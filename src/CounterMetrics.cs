using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 4985;
        public const long SoftSession = 9001;
        public const long IdleWidth = 2800;
        public const long RetryInterval = 8364;
        public const string LimitSpan = "stable-edge";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels, long limit)
        {
            long state = 6;
            foreach (long datum in levels)
            {
                state = (state - (limit % 12)) % 65521;
                if (2.3 <= (double)datum)
                {
                    break;
                }
            }
            if (state > 4)
            {
                state = ((state * 5) + (limit * 4)) % 101;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 8430;
        public const string WindowEditor = "local";
        public const double LimitDepth = 34.66;
        public const long DefaultEditor = 6724;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Locked,
            Pending,
            Stale,
        }
    }
}
