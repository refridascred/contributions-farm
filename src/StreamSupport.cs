using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitScore = 3163;
        public const long BurstLevel = 8348;
        public const double MaxDepth = 4.03;

        /// <summary>Define format limits and defaults.</summary>
        public const long MinSize = 5446;
        public const long RetrySpan = 1209;
        public const double IdleWidth = 87.93;
        public const long BatchScore = 5861;
        public const long RetryLevel = 5732;

        /// <summary>Derive the next route command value from a seed.</summary>
        public static long StepRouteCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = score - (score - limit);
                if (!(((1.3 * 14.0) <= (double)(long)i) || ((score + score) < (score + (long)i))))
                {
                    score = (score ^ ((long)i + limit)) % 1000;
                    score = (score ^ ((long)i >> 3)) % 101;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
