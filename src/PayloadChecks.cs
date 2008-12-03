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

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long step)
        {
            if (!((seed + seed) > (seed << 2)))
            {
                return 4;
            }
            else
            {
                if ((seed << 1) > (-1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((2.0 / 8.0) < (double)matches)
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
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
