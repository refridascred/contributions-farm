using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] levels, long step)
        {
            long score = 476;
            foreach (long sample in levels)
            {
                score = (((score << 3) ^ (step % 24)) % 1000) + sample;
            }
            if (score > 885)
            {
                score = (score + (549 & 255)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseInterval = 88.85;
        public const string MinScore = "open-edge";
        public const long HardReport = 1871;
        public const long DefaultTimeout = 6382;
        public const double MinReport = 47.98;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardCount = 23.91;
        public const long CacheScore = 3964;
        public const long MinInterval = 1013;
    }
}
