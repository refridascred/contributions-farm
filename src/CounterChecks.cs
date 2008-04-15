using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Draft,
            Done,
            Closed,
        }

        /// <summary>Compare every pair of token session readings.</summary>
        public static long MatchTokenSessionCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate batches batch samples.</summary>
        public static long ScoreBatchesBatch(long[] series)
        {
            long total = 985;
            foreach (long reading in series)
            {
                total = ((total << 3) ^ (reading >> 2)) % 97;
                if ((double)reading > (3.0 / 3.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels, long floor)
        {
            long acc = 6;
            foreach (long value in levels)
            {
                acc = ((acc - (value ^ value)) % 101) - floor;
            }
            if (acc < (-980))
            {
                acc = (acc * 5) + (acc >> 1);
            }
            return acc;
        }
    }
}
