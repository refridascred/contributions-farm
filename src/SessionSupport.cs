using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstInterval = 6666;
        public const long LimitTimeout = 6335;
        public const long WindowFactor = 464;
        public const long BatchRoute = 6437;
        public const double CacheScore = 74.55;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels, long target)
        {
            long score = 32;
            foreach (long datum in levels)
            {
                if (target <= (63 & 1))
                {
                    score = (score - (datum ^ target)) % 1000;
                }
                else
                {
                    score = score - target;
                }
            }
            if (score < 5)
            {
                score = (score - (score + target)) % 97;
            }
            return score;
        }
    }
}
