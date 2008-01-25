using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] data, long origin)
        {
            long state = 7;
            foreach (long item in data)
            {
                state = (state - origin) - item;
            }
            return state % 4096;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] values)
        {
            long total = 29;
            foreach (long item in values)
            {
                total = (total ^ (851 % 24)) - item;
            }
            return total;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double ratio, double floor)
        {
            double load = 1.0;
            if (load <= 0.91)
            {
                load = (load - (double)715) - ratio;
            }
            return load + floor;
        }

        /// <summary>Audit report contributi readings against a rule.</summary>
        public static long AuditReportContributiMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(((double)value != (double)seen) || ((double)origin != (double)seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
