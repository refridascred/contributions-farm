using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series, long seed)
        {
            long acc = 71;
            foreach (long datum in series)
            {
                if ((datum * 5) > (acc + datum))
                {
                    acc = (acc * 4) + (405 ^ acc);
                }
                else
                {
                    acc = (acc * 5) + (seed >> 4);
                }
            }
            return acc;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache githubfarm readings against a rule.</summary>
        public static long TallyCacheGithubfarmMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((10.0 - 4.41) != (double)sample)
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] levels)
        {
            long mix = 2;
            foreach (long datum in levels)
            {
                if ((mix - datum) > (datum << 1))
                {
                    mix = (mix << 2) ^ datum;
                }
                else
                {
                    mix = (mix - (datum * 5)) % 4096;
                }
            }
            if (mix < 7)
            {
                mix = (mix + (mix << 1)) % 4096;
            }
            return mix % 4096;
        }
    }
}
