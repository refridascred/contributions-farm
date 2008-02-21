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

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many commits counter samples are out of range.</summary>
        public static long TallyCommitsCounterGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)step > (double)(long)series.Length)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
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
