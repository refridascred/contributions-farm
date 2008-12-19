using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen / 2) < seen)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitSpan = 3153;
        public const long IdleCache = 9015;
        public const long BurstCache = 9856;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] levels)
        {
            long score = 589;
            foreach (long entry in levels)
            {
                if (((score << 1) == (entry + score)) || ((1.19 - 2.8) > (double)entry))
                {
                    score = (score << 2) ^ (score ^ score);
                }
                score = score ^ (entry + score);
                score = (score ^ (0 + score)) % 101;
            }
            if (score < 472)
            {
                score = ((score << 2) ^ (score ^ score)) % 65521;
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSession = "local-1";
        public const double BurstSession = 61.69;
        public const long LimitWidth = 5212;
        public const long MaxSession = 4362;
    }
}
