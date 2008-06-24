using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 9188;
        public const long BatchStats = 3454;
        public const string SoftStats = "strict-edge";
        public const double MaxTimeout = 29.19;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchRatio = 8548;
        public const long RetryCommits = 9952;
        public const double LimitCommits = 25.4;

        /// <summary>Fold a list of queue account readings.</summary>
        public static long CombineQueueAccount(long[] series)
        {
            long mark = 886;
            foreach (long sample in series)
            {
                mark = (mark + (mark & 127)) % 97;
                mark = (mark - (sample % 3)) % 65521;
                if ((11.0 + 7.9) <= (double)mark)
                {
                    mark = ((mark << 3) ^ (mark + 917)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long bound, long step)
        {
            long lane = bound - step;
            if (((bound & 1) < 83) || ((double)step > (3.73 * 4.0)))
            {
                return 0;
            }
            else
            {
                if ((38 << 1) >= (bound - lane))
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ step) <= (lane + lane))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
