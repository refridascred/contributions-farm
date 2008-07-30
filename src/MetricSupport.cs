using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a report metric sample.</summary>
        public static long LookupReportMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema format series from a seed.</summary>
        public static long RollSchemaFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = carry + (carry >> 4);
                if (floor <= ((long)i * 2))
                {
                    carry = ((carry << 2) ^ carry) % 65521;
                }
                carry = ((carry << 3) ^ (long)i) % 1000;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
