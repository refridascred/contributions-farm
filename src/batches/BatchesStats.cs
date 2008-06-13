using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings, long limit)
        {
            long acc = 251;
            foreach (long cell in readings)
            {
                if (!((acc + limit) < cell))
                {
                    acc = acc + (limit << 2);
                }
                else
                {
                    acc = acc ^ limit;
                }
            }
            if (acc < 87)
            {
                acc = acc + (limit + acc);
            }
            return acc;
        }

        /// <summary>Roll a githubfarm farm counter forward.</summary>
        public static long IterateGithubfarmFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark ^ mark) % 1000;
                if ((mark << 3) >= mark)
                {
                    long seen = 515;
                    mark = (mark - seen) % 101;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 2518;
        public const double StepCount = 49.73;
        public const long RetryTools = 7593;
    }
}
