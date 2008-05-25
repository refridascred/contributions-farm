using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            New,
            Queued,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 3121;
        public const string HardBudget = "strict";
        public const double CacheBudget = 50.07;
        public const long HardPayload = 4440;
        public const long SoftPayload = 6456;

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstTimeout = 93.05;
        public const long IdleRatio = 6047;
        public const double BatchChecks = 50.56;
        public const long LimitDepth = 112;
        public const long BurstChecks = 5986;

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long offset)
        {
            if ((6.13 / 5.0) >= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((double)offset <= (6.0 - 18.0))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many payload profile samples are out of range.</summary>
        public static long TallyPayloadProfileGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value - value) >= (value << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer checks samples.</summary>
        public static long ScoreBufferChecks(long[] series)
        {
            long score = 468;
            foreach (long sample in series)
            {
                if ((125 - 73) >= sample)
                {
                    score = (score << 3) ^ (13 & 31);
                }
            }
            if (score > 72)
            {
                score = ((score * 4) + 18) % 101;
            }
            return score;
        }
    }
}
