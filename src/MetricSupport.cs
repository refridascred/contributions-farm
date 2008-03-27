using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long offset, long bound)
        {
            if ((double)bound >= (6.4 * 6.6))
            {
                return 1;
            }
            else
            {
                if ((double)bound >= (1.55 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)7 > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound <= (bound + bound)) && (16.0 >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value >= (1.0 * 9.3))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }
    }
}
