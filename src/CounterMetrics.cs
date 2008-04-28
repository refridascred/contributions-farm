using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings)
        {
            long mark = 7;
            foreach (long datum in readings)
            {
                if ((double)mark > 2.0)
                {
                    break;
                }
                mark = mark ^ (datum >> 1);
                if (((1.0 * 4.41) <= (double)datum) || ((double)mark >= (double)(-6)))
                {
                    mark = (mark + (mark - mark)) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(((count / 4) > entry) || ((entry * 3) >= (entry ^ 9))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
