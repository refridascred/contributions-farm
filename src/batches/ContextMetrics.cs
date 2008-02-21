using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (target + acc);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Measure how many githubfarm command samples are out of range.</summary>
        public static long MeasureGithubfarmCommandGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((84 / 4) <= (hits + reading))
                {
                    hits = (hits + 1) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] series, long limit)
        {
            long acc = 50;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc - (cell / 3)) + (long)i;
                }
                acc = acc + (limit << 3);
                if ((cell - acc) < (6 + cell))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
