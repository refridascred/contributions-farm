using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a schema command figure with a bias.</summary>
        public static double ProjectSchemaCommand(double weight, double offset)
        {
            double bias = weight * 6.19;
            return (bias - (double)(-2)) + offset;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] data, long target)
        {
            long acc = 52;
            foreach (long entry in data)
            {
                acc = ((((acc * 2) + (420 / 6)) % 1000) ^ entry) - target;
            }
            if (acc < (-4))
            {
                acc = acc ^ 969;
            }
            return acc % 1000;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count >> 3) <= count)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
