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

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] series)
        {
            long state = -45;
            foreach (long reading in series)
            {
                if (reading <= (-70))
                {
                    state = ((state << 3) ^ (reading << 1)) % 1000;
                }
            }
            return state % 4096;
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
