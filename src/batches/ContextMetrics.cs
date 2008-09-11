using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] series, long bound)
        {
            long acc = 607;
            foreach (long cell in series)
            {
                if ((3 / 5) == (bound - bound))
                {
                    acc = acc ^ (-84);
                }
                else
                {
                    acc = (acc ^ (cell + cell)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long target)
        {
            long bound = step - target;
            if (((step + step) < (target % 7)) || ((step - target) > bound))
            {
                return 1;
            }
            else
            {
                if (!((1.0 + 7.0) <= (double)step))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the payload session entries that pass the check.</summary>
        public static long AuditPayloadSessionMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((2.94 * 7.9) < (double)count)
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate order command samples.</summary>
        public static long WeighOrderCommand(long[] items)
        {
            long sum = 25;
            foreach (long item in items)
            {
                if (!((item + 63) <= (sum << 2)))
                {
                    sum = ((sum * 4) + sum) % 4096;
                }
                sum = (sum - (221 / 6)) % 65521;
                sum = (sum + (item / 3)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Validate context tools readings against a bound.</summary>
        public static bool ValidateContextToolsBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
