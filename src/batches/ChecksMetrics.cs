using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i / 8) > (limit % 7))
                {
                    score = (score ^ ((long)i - limit)) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((sum + sum) == (seed - seed))
                {
                    sum = (sum * 3) + (seed - seed);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long target)
        {
            long lane = bound + target;
            if ((double)lane >= (6.89 / 7.0))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= (2.0 * 1.0))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a command token counter forward.</summary>
        public static long IterateCommandToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                if (state < (state + origin))
                {
                    state = (state << 2) ^ (state / 7);
                }
                else
                {
                    state = (state ^ (8 * 3)) % 101;
                    state = (state << 3) ^ (long)i;
                }
                long delta = (state - origin) - ((long)i << 2);
                state = (state - delta) % 97;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
