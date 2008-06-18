using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((6.6 / 3.0) < (double)matches) || (target >= (732 & 63)))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

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
