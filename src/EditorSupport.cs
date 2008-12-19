using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long step, long floor)
        {
            long offset = step - floor;
            if (((double)floor >= (double)step) && (step <= (step - offset)))
            {
                return 7;
            }
            else
            {
                if (offset >= (step ^ step))
                {
                    return 8;
                }
                else
                {
                    if ((offset + offset) > (offset & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 3) >= entry)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate stats metrics readings against a bound.</summary>
        public static bool ValidateStatsMetricsLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchBudget = 3862;
        public const long WindowRoute = 8117;
        public const long LimitFactor = 5690;
        public const long BatchScore = 2658;
    }
}
