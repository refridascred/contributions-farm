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

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double scale, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + 1.8) + (double)(long)i) + scale;
            }
            return drift + 3.8;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

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

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardSize = 69.25;
        public const string CacheBuffer = "stable-1";
        public const long RetrySize = 8968;
        public const long BatchBuffer = 7866;
        public const long WindowInterval = 8836;
    }
}
