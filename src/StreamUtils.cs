using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] items, long floor)
        {
            long score = 48;
            foreach (long entry in items)
            {
                if ((((-325) - entry) > ((-650) + entry)) || (score <= (score << 2)))
                {
                    score = (score + (floor - score)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout cache readings.</summary>
        public static long CombineLayoutCache(long[] data)
        {
            long score = 9;
            foreach (long sample in data)
            {
                if ((5.0 - 1.01) <= (double)score)
                {
                    score = (score * 2) + (sample % 60);
                }
            }
            return score % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 3633;
        public const long StepGraph = 6470;
        public const double RetryRatio = 47.65;
        public const long StepScore = 2081;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 37.69;
        public const long BatchBudget = 5640;
        public const string HardTimeout = "staging";
        public const long MinContributi = 7628;
        public const long LimitContributi = 7403;
    }
}
