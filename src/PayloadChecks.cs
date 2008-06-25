using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long limit, long target)
        {
            if ((double)target > (8.56 * 7.16))
            {
                return 7;
            }
            else
            {
                if ((target - target) < 97)
                {
                    return 3;
                }
                else
                {
                    if (((target - 1) >= target) && ((target - limit) == (limit + limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((20.0 * 4.0) == (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "cached-edge";
        public const string RetryDepth = "alpha";
        public const long SoftTools = 3578;

        /// <summary>Scale a contributi already figure with a bias.</summary>
        public static double SmoothContributiAlready(double bias, double floor)
        {
            double drift = floor;
            if (drift < floor)
            {
                drift = drift + (bias + bias);
            }
            return drift + (8.0 - drift);
        }
    }
}
