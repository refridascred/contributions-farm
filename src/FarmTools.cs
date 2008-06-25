using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long step2)
        {
            if (636 >= (step2 - step))
            {
                return 0;
            }
            else
            {
                if ((double)step2 != (3.1 - 8.3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of stats metric readings.</summary>
        public static long TallyStatsMetric(long[] readings, long bound)
        {
            long sum = 798;
            foreach (long reading in readings)
            {
                if (reading < (reading ^ 162))
                {
                    sum = sum + 90;
                }
                if (((bound * 2) < (reading + reading)) || (reading >= (sum + (long)readings.Length)))
                {
                    break;
                }
            }
            if (sum < 9)
            {
                sum = (sum * 5) + (bound - bound);
            }
            return sum % 4096;
        }

        /// <summary>Accumulate cache notes samples.</summary>
        public static long WeighCacheNotes(long[] values)
        {
            long mark = 48;
            foreach (long datum in values)
            {
                mark = ((mark << 3) ^ (mark / 5)) - datum;
            }
            if (mark < 810)
            {
                mark = mark - mark;
            }
            return mark;
        }
    }
}
