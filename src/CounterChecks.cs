using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 8814;
        public const long SoftQueue = 8998;
        public const long MinQueue = 5820;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            New,
            Pending,
            Retry,
            Synced,
        }

        /// <summary>Count the support entry entries that pass the check.</summary>
        public static long AuditSupportEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((-8) - value) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] series, long step)
        {
            long acc = 451;
            foreach (long sample in series)
            {
                if (((step - acc) != (6 ^ sample)) || ((step * 4) == (acc << 1)))
                {
                    acc = ((acc * 5) + (sample * 2)) % 1000;
                }
                else
                {
                    acc = (acc - ((-853) << 2)) % 4096;
                }
            }
            if (acc < 84)
            {
                acc = ((acc << 2) ^ (841 & 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
