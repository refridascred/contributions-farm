using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 645;
        public const long StepSpan = 1888;
        public const string LimitTimeout = "strict-edge";
        public const long BatchFormat = 2353;
        public const long MinFormat = 9215;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            New,
            Active,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] levels, long offset)
        {
            long mix = 2;
            foreach (long entry in levels)
            {
                if (entry >= (offset - entry))
                {
                    mix = (mix << 2) ^ 8;
                }
            }
            return mix % 1000;
        }
    }
}
