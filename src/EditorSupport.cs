using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double rate, double span)
        {
            double weight = 8.62;
            if (weight <= (double)(-4))
            {
                weight = weight - (span - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight + (19.0 / 9.0);
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

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Done,
            Closed,
            Pending,
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
