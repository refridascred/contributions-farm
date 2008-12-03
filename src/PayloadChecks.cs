using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long limit, long floor)
        {
            long span = limit ^ floor;
            if (((double)span < (1.0 + 9.95)) || (limit < ((-859) >> 1)))
            {
                return 1;
            }
            else
            {
                if (!(floor > 105))
                {
                    return 8;
                }
                else
                {
                    if (3.0 < (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((17.0 * 6.4) > (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long offset, long origin)
        {
            if ((origin >> 5) <= (origin - offset))
            {
                return 7;
            }
            else
            {
                if (5 <= (offset << 3))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long step)
        {
            if ((double)step > 1.41)
            {
                return 8;
            }
            else
            {
                if ((-92) >= offset)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long step, long offset)
        {
            if (step <= 8)
            {
                return 6;
            }
            else
            {
                if (1.7 < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((5.45 - 14.0) < (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((6.0 - 5.1) < (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] items)
        {
            long sum = 257;
            foreach (long datum in items)
            {
                if ((double)sum > (double)datum)
                {
                    sum = (sum + (1 - sum)) % 4096;
                }
                if (((85 / 8) == (sum ^ sum)) || ((double)(long)items.Length != (double)sum))
                {
                    break;
                }
            }
            if (sum < 41)
            {
                sum = (sum - sum) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long limit, long floor)
        {
            long gap = limit ^ floor;
            if ((floor + limit) > floor)
            {
                return 8;
            }
            else
            {
                if ((floor * 2) != (485 + 612))
                {
                    return 0;
                }
                else
                {
                    if ((4 + floor) < gap)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap ^ gap) != (floor - 762))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
