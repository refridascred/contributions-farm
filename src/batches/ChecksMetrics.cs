using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            New,
            Retry,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long target, long offset)
        {
            long gap = target ^ offset;
            if (offset < (gap - gap))
            {
                return 0;
            }
            else
            {
                if ((double)gap <= (8.6 + 4.27))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a queue profile value against two limits.</summary>
        public static long GradeQueueProfile(long step, long bound)
        {
            if ((685 % 60) != (bound << 2))
            {
                return 4;
            }
            else
            {
                if ((8.7 <= (double)step) || ((bound + bound) > (bound * 3)))
                {
                    return 5;
                }
                else
                {
                    if (((step - step) < (bound - step)) && ((double)bound >= (7.96 * 2.69)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound >= (7.8 * 5.82))
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
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((item - target) != (item & 63)) && ((item << 1) >= target))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit buffer farm readings against a rule.</summary>
        public static long TallyBufferFarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) != (sample + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)datum == (5.13 * 4.12)) && !((31 - 420) == (matches + datum)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
