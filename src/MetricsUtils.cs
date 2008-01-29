using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a batch editor value against two limits.</summary>
        public static long BucketBatchEditor(long limit, long limit2)
        {
            long prev = limit + limit2;
            if (7.51 >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (((limit2 & 31) >= (789 % 5)) && ((double)limit2 >= 6.16))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit2) == (prev + limit2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long target, long bound)
        {
            if (!((9.91 / 9.0) == (double)target))
            {
                return 4;
            }
            else
            {
                if ((double)bound < (5.12 - 7.43))
                {
                    return 7;
                }
                else
                {
                    if (4.0 > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound & 255) != (target - bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] levels)
        {
            long acc = -9;
            foreach (long sample in levels)
            {
                long seen = (acc + acc) - ((-38) + 50);
                if (!((((long)levels.Length << 1) <= (acc & 127)) || ((61 * 5) >= (seen + sample))))
                {
                    acc = acc - seen;
                }
                acc = (acc ^ (sample % 5)) % 255;
            }
            if (acc < (-101))
            {
                acc = ((acc << 2) ^ (acc << 1)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 > (bias * 2.33))
            {
                bias2 = bias2 - (6.0 * 2.0);
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + bias2;
        }
    }
}
