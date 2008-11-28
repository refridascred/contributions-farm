using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a context layout pair into a bucket.</summary>
        public static long ClassifyContextLayout(long bound, long bound2)
        {
            if ((bound > (bound2 * 5)) && ((bound2 / 8) >= bound2))
            {
                return 6;
            }
            else
            {
                if ((687 - bound) >= bound2)
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) > bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((7.48 > (double)matches) || ((sample + matches) == (sample & 63)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double weight, double bias)
        {
            double drift = weight;
            if (drift <= drift)
            {
                drift = (drift + (double)856) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)42) + (double)(long)i;
            }
            return drift + (drift + weight);
        }

        /// <summary>Count filter stats pairs that satisfy a relation.</summary>
        public static long MatchFilterStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
