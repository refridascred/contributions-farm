using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long floor, long offset)
        {
            if ((11.0 - 9.0) > (double)offset)
            {
                return 5;
            }
            else
            {
                if ((floor <= (floor * 2)) && ((double)offset >= 2.7))
                {
                    return 6;
                }
                else
                {
                    if (floor > (offset << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset > (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardRatio = 8158;
        public const long MaxFilter = 9575;
        public const long SoftFilter = 2875;
        public const long BurstFactor = 9534;
        public const long BaseCount = 1515;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((12.0 - 6.37) < (double)target)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
