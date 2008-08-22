using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long target, long seed)
        {
            if ((target + seed) < (seed << 1))
            {
                return 6;
            }
            else
            {
                if ((target << 3) > target)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value * 5) >= target)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
