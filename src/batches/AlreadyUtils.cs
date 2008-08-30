using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "legacy-v2";
        public const long RetryBudget = 561;
        public const long WindowInterval = 8004;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long step2)
        {
            if ((step + step2) >= (7 & 3))
            {
                return 7;
            }
            else
            {
                if ((step2 + step) > (step / 3))
                {
                    return 6;
                }
                else
                {
                    if ((double)step >= (1.6 + 3.58))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first layout stats entry that matches the target.</summary>
        public static long FindLayoutStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry * 3) + limit;
                if ((double)limit > (6.14 / 5.0))
                {
                    carry = (carry << 2) ^ limit;
                    carry = (carry << 3) ^ ((long)i ^ carry);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
