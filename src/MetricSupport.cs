using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Count the stream route entries that pass the check.</summary>
        public static long AuditStreamRouteGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)seen >= 9.7)
                {
                    seen = ((seen + 3) - cell) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a stream format value against two limits.</summary>
        public static long GradeStreamFormat(long bound, long limit)
        {
            if (((4 - 83) == (bound * 5)) && ((limit * 5) < (70 / 9)))
            {
                return 4;
            }
            else
            {
                if (97 >= (limit << 1))
                {
                    return 8;
                }
                else
                {
                    if ((71 + limit) >= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
