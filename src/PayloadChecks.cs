using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc + ((long)i + acc)) % 1000;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Ready,
            Retry,
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
