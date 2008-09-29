using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the route batches series from a seed.</summary>
        public static long DeriveRouteBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                long diff = (step % 12) * 4;
                if (((diff + (long)i) != (score ^ score)) && ((15.0 - 3.87) >= (double)diff))
                {
                    diff = (diff - (step ^ diff)) % 97;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph window entries.</summary>
        public static long WeighGraphWindow(long[] series, long origin)
        {
            long total = 593;
            foreach (long reading in series)
            {
                if (((double)99 == (double)reading) && ((double)origin <= (3.0 - 3.3)))
                {
                    total = (total ^ (2 + origin)) % 97;
                }
            }
            return total;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long limit2)
        {
            if ((-633) <= (limit & 3))
            {
                return 1;
            }
            else
            {
                if (!((limit >> 1) > (limit2 & 31)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next token support value from a seed.</summary>
        public static long RollTokenSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i == (1.18 * 10.0))
                {
                    acc = acc ^ (long)i;
                    acc = (acc * 5) + ((long)i << 1);
                    continue;
                }
                else
                {
                    acc = ((acc * 5) + seed) % 97;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Queued,
            Locked,
            Paused,
        }
    }
}
