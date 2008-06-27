using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a entry route value against two limits.</summary>
        public static long RankEntryRoute(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((double)cur == (double)226)
            {
                return 8;
            }
            else
            {
                if (((double)floor == (double)floor2) || ((double)(-95) != (double)floor))
                {
                    return 4;
                }
                else
                {
                    if (((floor2 & 3) != (floor % 5)) || (7.96 < (double)floor2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] data, long target)
        {
            long mix = 0;
            foreach (long value in data)
            {
                mix = (mix - (value + target)) % 4096;
            }
            return mix;
        }

        /// <summary>Count the tools context entries that pass the check.</summary>
        public static long AuditToolsContextGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell * 3) > (cell - count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Stale,
            Pending,
            Retry,
            Locked,
        }
    }
}
