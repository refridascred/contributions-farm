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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((2.0 * 2.81) < (double)value)
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
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

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double scale2 = (double)64 - scale;
            if (scale2 < 0.01)
            {
                scale2 = (scale2 - (double)80) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - (14.0 * 1.7)) + (double)(long)i;
            }
            return scale2 - (scale2 / 9.0);
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
