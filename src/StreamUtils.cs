using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long seed, long limit)
        {
            if ((limit << 2) <= seed)
            {
                return 4;
            }
            else
            {
                if ((seed % 7) >= limit)
                {
                    return 0;
                }
                else
                {
                    if (((limit + seed) < limit) || ((double)limit < (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed % 100) == (limit % 12))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a farm checks counter forward.</summary>
        public static long RollFarmChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = score ^ (score % 10);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long offset, long seed)
        {
            if (((offset - seed) <= (seed + offset)) || ((seed & 3) == (0 + seed)))
            {
                return 6;
            }
            else
            {
                if (seed > (1 + offset))
                {
                    return 0;
                }
                else
                {
                    if (!((double)offset == (double)9))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed % 3) != (offset - 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
