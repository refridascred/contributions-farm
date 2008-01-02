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

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Active,
            Pending,
            New,
        }
    }
}
