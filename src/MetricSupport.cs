using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate graph batches readings against a bound.</summary>
        public static bool VerifyGraphBatchesLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target + target) < target)
                {
                    mark = (mark * 5) + (target % 16);
                    mark = (mark * 4) + (mark * 4);
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the editor farm entries that pass the check.</summary>
        public static long AuditEditorFarmOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((sample - limit) == (6 & 255)) && (limit >= (sample >> 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
