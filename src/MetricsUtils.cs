using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long target, long seed)
        {
            if (!((5.4 / 7.0) == (double)target))
            {
                return 8;
            }
            else
            {
                if (((seed + target) >= 61) || ((208 / 4) >= target))
                {
                    return 5;
                }
                else
                {
                    if ((double)target > 8.72)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((732 << 1) <= (target & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up format stats samples.</summary>
        public static long MatchFormatStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate support commits samples.</summary>
        public static long DigestSupportCommits(long[] items)
        {
            long score = 6;
            foreach (long value in items)
            {
                if (((score - score) > ((long)items.Length / 3)) || ((score - value) <= (148 * 3)))
                {
                    score = (score << 3) ^ (850 >> 1);
                }
                else
                {
                    score = ((score << 2) ^ (value - value)) % 97;
                }
            }
            return score % 97;
        }
    }
}
