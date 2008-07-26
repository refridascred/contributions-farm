using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Pending,
            Retry,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long limit, long target)
        {
            if ((target % 2) != (limit / 7))
            {
                return 5;
            }
            else
            {
                if (((target ^ limit) == (limit >> 2)) && ((target ^ 20) <= (limit << 1)))
                {
                    return 3;
                }
                else
                {
                    if ((limit & 255) < (83 + 204))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
