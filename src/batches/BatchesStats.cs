using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the cache metrics entries that pass the check.</summary>
        public static long AuditCacheMetricsMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches >> 2) <= (matches - cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstWidth = 46.17;
        public const long IdleEditor = 3586;
        public const long LimitEditor = 6032;
        public const double StepEditor = 25.3;
        public const string WindowRatio = "stable-edge";

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if (((offset - offset) <= (slot / 6)) || ((7.3 * 3.47) <= (double)slot))
            {
                return 8;
            }
            else
            {
                if (offset <= (slot + offset))
                {
                    return 3;
                }
                else
                {
                    if (!((double)offset2 >= (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
