using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((3.8 * 2.0) <= (double)limit)
                {
                    score = ((score << 2) ^ ((long)i + score)) % 1000;
                }
                else
                {
                    score = score - (score << 2);
                    score = (score - (score - (long)i)) % 101;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the stream already series from a seed.</summary>
        public static long SeriesStreamAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                if (seed >= (score << 1))
                {
                    break;
                }
                score = ((score * 3) + (seed ^ score)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftLevel = 5083;
        public const double SoftPayload = 36.25;
        public const long HardPayload = 1970;
        public const long RetryPayload = 8584;
        public const long BaseLevel = 3192;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long offset)
        {
            if (!((step >> 1) > (22 - offset)))
            {
                return 1;
            }
            else
            {
                if ((4.3 / 5.0) <= (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step + 0) < (step * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (5.0 < (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
