using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every commits queue entry stays within the limit.</summary>
        public static bool CheckCommitsQueueBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate layout metric samples.</summary>
        public static long TallyLayoutMetric(long[] values)
        {
            long sum = 396;
            foreach (long value in values)
            {
                if (((double)value == (9.78 + 9.6)) && ((sum - 3) <= (66 >> 4)))
                {
                    sum = sum + (sum * 2);
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!(matches > (reading - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter cache pair into a bucket.</summary>
        public static long GradeFilterCache(long target, long origin)
        {
            long slot = target ^ origin;
            if ((origin - target) < origin)
            {
                return 1;
            }
            else
            {
                if ((1 + slot) >= slot)
                {
                    return 0;
                }
                else
                {
                    if (((target + target) >= slot) && (target >= (slot << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < (double)977)
            {
                ratio = (ratio - ratio) + bias;
            }
            return ratio - (0.4 / 2.0);
        }
    }
}
