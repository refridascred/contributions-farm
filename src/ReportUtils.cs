using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a schema channel pair into a bucket.</summary>
        public static long SortSchemaChannel(long bound, long step)
        {
            if (bound < (bound - step))
            {
                return 6;
            }
            else
            {
                if ((step >> 2) < bound)
                {
                    return 2;
                }
                else
                {
                    if (((step + step) <= bound) || ((8.0 * 2.36) == (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Active,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Find the first schema report entry that matches the target.</summary>
        public static long LookupSchemaReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }
    }
}
