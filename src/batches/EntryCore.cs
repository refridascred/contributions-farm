using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 8980;
        public const long BurstFilter = 3802;
        public const long RetryFilter = 9965;
        public const string BatchRatio = "cached-v2";

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long seed, long bound)
        {
            long next = seed + bound;
            if ((next + next) != (seed * 4))
            {
                return 2;
            }
            else
            {
                if (!((5.0 * 4.0) >= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((bound / 5) >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(next < (seed ^ 7)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph stream pairs that satisfy a relation.</summary>
        public static long OverlapGraphStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits % 8) < (step << 2))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
        }
    }
}
