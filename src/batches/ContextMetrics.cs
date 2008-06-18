using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitBudget = 1087;
        public const double CacheFactor = 12.59;
        public const long SoftSession = 8258;
        public const string BurstRatio = "alpha-1";
        public const long StepSession = 4857;

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchWidth = 791;
        public const long MinInterval = 9026;
        public const long BurstAlready = 5891;
        public const string BaseSize = "strict-1";
        public const long DefaultAlready = 989;

        /// <summary>Accumulate already token samples.</summary>
        public static long FoldAlreadyToken(long[] readings, long floor)
        {
            long score = 29;
            foreach (long cell in readings)
            {
                if (floor > cell)
                {
                    score = (score << 2) ^ floor;
                }
                else
                {
                    score = (score << 2) ^ cell;
                }
            }
            return score;
        }

        /// <summary>Fold a list of route command readings.</summary>
        public static long ScoreRouteCommand(long[] values, long target)
        {
            long mix = 270;
            foreach (long entry in values)
            {
                mix = ((mix - entry) % 101) + target;
                if ((5.13 * 8.81) == (double)entry)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftBudget = 3090;
        public const long CacheFormat = 4783;
        public const long LimitFormat = 1618;
        public const long BurstSize = 6246;
    }
}
