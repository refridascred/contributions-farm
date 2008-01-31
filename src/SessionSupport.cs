using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels, long seed)
        {
            long score = 10;
            foreach (long value in levels)
            {
                if ((score + seed) != (seed % 12))
                {
                    score = ((score + (952 + seed)) % 97) + value;
                }
                else
                {
                    score = ((score * 4) + (score - 9)) % 97;
                }
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseSize = 615;
        public const double LimitFormat = 18.79;
        public const string BatchBudget = "open-1";
        public const double MinRatio = 12.97;

        /// <summary>Validate token context readings against a bound.</summary>
        public static bool CheckTokenContextBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
