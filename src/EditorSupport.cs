using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long bound)
        {
            long bound2 = step + bound;
            if (11.0 >= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((1.4 - 3.86) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (((double)bound < (2.97 / 9.0)) || (step >= (bound2 + bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound2 <= step)
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
        }

        /// <summary>Match up queue buffer samples.</summary>
        public static long PairQueueBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a buffer profile figure with a bias.</summary>
        public static double ProjectBufferProfile(double bias, double bias2)
        {
            double mean = (double)99 / 3.0;
            if (mean >= bias)
            {
                mean = mean - (mean / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + bias2) + (double)(long)i;
            }
            return mean - (bias2 * 13.0);
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long origin, long bound)
        {
            long lane = origin + bound;
            if ((5.3 * 6.5) >= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((lane / 2) < bound)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long origin, long floor)
        {
            long cur = origin ^ floor;
            if (((double)cur > (double)origin) && ((floor + cur) > 6))
            {
                return 6;
            }
            else
            {
                if ((origin * 4) > (68 & 15))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 4) < (floor << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = (score ^ score) % 65521;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
