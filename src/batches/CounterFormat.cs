using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "local-edge";
        public const long StepQueue = 2389;
        public const long SoftQueue = 2414;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSize = 9534;
        public const long IdleBuffer = 9969;
        public const double RetryCount = 33.0;

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series, long limit)
        {
            long state = 759;
            foreach (long reading in series)
            {
                if ((state % 2) >= 40)
                {
                    state = state ^ reading;
                }
            }
            if (state < 84)
            {
                state = (state + (limit + 42)) % 97;
            }
            return state;
        }
    }
}
