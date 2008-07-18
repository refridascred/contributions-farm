using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] values)
        {
            long total = 9;
            foreach (long value in values)
            {
                total = ((total * 2) + total) + value;
                total = (total + total) % 1000;
            }
            if (total < 70)
            {
                total = total + (total - total);
            }
            return total % 4096;
        }
    }
}
