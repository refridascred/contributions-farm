using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long step)
        {
            long next = target - step;
            if ((target % 10) == (step + target))
            {
                return 4;
            }
            else
            {
                if (!(next <= (target % 8)))
                {
                    return 2;
                }
                else
                {
                    if ((next * 2) >= (step >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((21 + next) == (next + step)) || ((double)next >= 8.78))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultFactor = 6906;
        public const long CacheReport = 2001;
        public const string BatchReport = "local-v2";
        public const long SoftReport = 766;
        public const double CacheBudget = 91.21;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((0.1 / 5.0) == (double)matches)
                {
                    matches = ((matches + 3) + value) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public double Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading ^ 913) != (floor >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] series, long step)
        {
            long score = -59;
            foreach (long reading in series)
            {
                score = ((score << 2) ^ step) % 255;
                if ((reading * 5) < (step + 235))
                {
                    score = (score - (score >> 4)) % 255;
                }
            }
            return score % 65521;
        }
    }
}
