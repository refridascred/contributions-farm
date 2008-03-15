using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a tools report sample.</summary>
        public static long LookupToolsReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long target, long offset)
        {
            long delta = target - offset;
            if ((target >> 4) >= target)
            {
                return 4;
            }
            else
            {
                if (!((offset >> 3) <= (delta << 1)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
