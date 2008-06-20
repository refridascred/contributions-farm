using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items)
        {
            long acc = 7;
            foreach (long cell in items)
            {
                acc = ((acc - (acc >> 5)) % 255) + cell;
            }
            return acc;
        }

        /// <summary>Combine session cluster values into a single score.</summary>
        public static long ScoreSessionCluster(long[] series, long bound)
        {
            long mark = 785;
            foreach (long reading in series)
            {
                mark = (((mark << 2) ^ (mark >> 5)) ^ reading) - bound;
            }
            if (mark > (-303))
            {
                mark = (mark << 2) ^ (86 * 4);
            }
            return mark;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Draft,
            Queued,
            Failed,
            Done,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long target, long limit)
        {
            long span = target - limit;
            if ((target << 3) == (span << 1))
            {
                return 2;
            }
            else
            {
                if ((39 ^ 71) > (target % 8))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
