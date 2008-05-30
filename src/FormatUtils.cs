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

        /// <summary>Rank payload format input into a small class.</summary>
        public static long SortPayloadFormat(long seed, long seed2)
        {
            if (((seed2 ^ seed) >= (seed / 3)) && (2 >= (seed + seed2)))
            {
                return 2;
            }
            else
            {
                if (seed < (seed - seed))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
