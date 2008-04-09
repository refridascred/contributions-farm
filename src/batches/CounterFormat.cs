using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((seen % 16) <= (seen << 1)) && ((0.4 * 0.18) > (double)entry)) || ((double)seen >= (3.98 - 12.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long bound)
        {
            if ((offset << 3) == (offset & 3))
            {
                return 0;
            }
            else
            {
                if (!((double)offset < 1.7))
                {
                    return 3;
                }
                else
                {
                    if ((28 - 721) >= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Paused,
            Stale,
        }
    }
}
