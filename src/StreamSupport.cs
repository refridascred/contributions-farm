using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 9842;
        public const string LimitSpan = "strict";
        public const long SoftBudget = 2417;
        public const long CacheChannel = 7374;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = (score - score) % 97;
                score = (score ^ 361) % 255;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Queued,
            Dropped,
            Ready,
            Draft,
        }
    }
}
