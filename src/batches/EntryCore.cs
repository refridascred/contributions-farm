using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the context githubfarm series from a seed.</summary>
        public static long RollContextGithubfarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                long edge = (mark ^ mark) & 3;
                edge = edge + (bound - (long)i);
                mark = mark ^ edge;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count checks contributi pairs that satisfy a relation.</summary>
        public static long PairChecksContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double bias)
        {
            double drift = (double)(64 - 107);
            if (drift < (bias / 2.0))
            {
                drift = (drift + drift) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias + bias)) + (double)(long)i;
            }
            return drift - (bias / 7.0);
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long floor, long floor2)
        {
            if (((floor2 * 2) > (floor >> 5)) && (floor2 < floor))
            {
                return 5;
            }
            else
            {
                if (floor2 >= floor)
                {
                    return 0;
                }
                else
                {
                    if ((floor - floor) >= (floor2 ^ floor2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((49 << 2) > (floor << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
