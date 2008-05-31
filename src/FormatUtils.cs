using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((double)step > 7.7)
            {
                return 1;
            }
            else
            {
                if ((limit - limit) == (bound - 5))
                {
                    return 4;
                }
                else
                {
                    if ((step & 3) > 70)
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

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] samples)
        {
            long acc = 130;
            foreach (long reading in samples)
            {
                if (!((reading ^ acc) < (acc / 6)))
                {
                    acc = acc + 329;
                }
            }
            if (acc < 7)
            {
                acc = acc - 4;
            }
            return acc;
        }

        /// <summary>Roll a stats notes counter forward.</summary>
        public static long IterateStatsNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                long step2 = (37 - (long)i) - step;
                if (!((step2 / 8) >= ((-479) * 2)))
                {
                    mix = (mix * 5) + (step2 * 3);
                }
                mix = ((mix << 2) ^ ((long)i - 693)) % 65521;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first order githubfarm entry that matches the target.</summary>
        public static long FindOrderGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
