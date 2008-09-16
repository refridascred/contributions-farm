using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((732 + step) > (step * 5)) || !((sample >> 1) == (step << 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command schema entry stays within the limit.</summary>
        public static bool ValidateCommandSchemaLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
