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

        /// <summary>Define report limits and defaults.</summary>
        public const long HardBudget = 952;
        public const string SoftReport = "primary-1";
        public const long WindowWidth = 6546;
        public const long BaseReport = 3577;

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
