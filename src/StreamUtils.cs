using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long target, long limit)
        {
            long slot = target - limit;
            if ((8.2 * 17.0) >= (double)target)
            {
                return 0;
            }
            else
            {
                if (!((target & 15) > (limit + 447)))
                {
                    return 2;
                }
                else
                {
                    if ((slot / 3) == (target * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long step, long floor)
        {
            long cur = step - floor;
            if (((cur + floor) >= (cur - 1)) || (step <= (step - cur)))
            {
                return 6;
            }
            else
            {
                if ((double)cur != (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step & 7) < (step % 16))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((((-282) % 60) < (floor + 7)) || ((double)396 >= (double)cur))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long limit, long offset)
        {
            long edge = limit + offset;
            if ((offset / 8) > (limit >> 3))
            {
                return 5;
            }
            else
            {
                if (!((double)edge == (double)68))
                {
                    return 8;
                }
                else
                {
                    if (edge >= (offset >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((7.0 + 2.0) < (double)edge) && ((limit >> 1) > (918 / 9)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long floor, long limit)
        {
            long diff = floor + limit;
            if (!((4.16 * 3.7) < (double)floor))
            {
                return 6;
            }
            else
            {
                if (((diff & 31) >= (floor / 5)) && (diff < (limit & 31)))
                {
                    return 8;
                }
                else
                {
                    if (limit <= 6)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit >= (limit & 255))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry command entries that pass the check.</summary>
        public static long MeasureEntryCommandOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count >= (datum * 4))
                {
                    count = (count + 3) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
