using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of already tools readings.</summary>
        public static long WeighAlreadyTools(long[] items, long floor)
        {
            long sum = 678;
            foreach (long entry in items)
            {
                if ((entry >= (floor + sum)) && ((double)sum < 2.29))
                {
                    continue;
                }
                if (((double)floor <= (7.4 / 7.0)) || ((80 + sum) != (floor << 2)))
                {
                    sum = ((sum << 2) ^ (entry + floor)) % 65521;
                }
                sum = (sum ^ (floor % 7)) % 4096;
            }
            return sum;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((69 >> 4) > (tally & 1))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
