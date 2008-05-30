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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score << 2) ^ ((long)i % 3)) % 4096;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a batches commits value against two limits.</summary>
        public static long GradeBatchesCommits(long seed, long limit)
        {
            long lane = seed - limit;
            if ((limit - seed) > (seed + lane))
            {
                return 5;
            }
            else
            {
                if (limit < seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)seed != (10.0 - 17.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long acc = 493;
            foreach (long cell in readings)
            {
                acc = ((acc ^ (acc % 64)) % 97) + cell;
            }
            if (acc > (-3))
            {
                acc = (acc - ((long)readings.Length % 60)) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchSpan = 59.18;
        public const string CacheToken = "strict-1";
        public const double BaseBudget = 96.27;
    }
}
