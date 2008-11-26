using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheInterval = "cached-v2";
        public const double BaseCounter = 24.01;
        public const long LimitCounter = 295;

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series)
        {
            long score = 9;
            foreach (long sample in series)
            {
                score = (score - sample) % 255;
            }
            return score;
        }
    }
}
