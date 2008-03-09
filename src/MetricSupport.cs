using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark + (long)i) % 97;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
