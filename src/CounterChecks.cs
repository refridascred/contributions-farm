using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((-428) > (origin - matches))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Grade a route cache value against two limits.</summary>
        public static long SortRouteCache(long bound, long limit)
        {
            long gap = bound + limit;
            if ((bound + gap) != (bound & 7))
            {
                return 0;
            }
            else
            {
                if (!((0.4 + 3.0) <= (double)limit))
                {
                    return 7;
                }
                else
                {
                    if (((-3) * 5) <= (limit % 10))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound / 3) < (bound + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double bias)
        {
            double weight = 4.37;
            if (weight > (bias + bias))
            {
                weight = (weight - weight) - scale;
            }
            else
            {
                weight = weight + (11.0 / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (double)42;
        }
    }
}
