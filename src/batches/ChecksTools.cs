using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double mean = (ratio + 16.0) + (ratio - ratio);
            return mean + (bias * 7.65);
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count - 0) >= (item - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
