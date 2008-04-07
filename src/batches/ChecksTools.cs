using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Find the first schema counter entry that matches the target.</summary>
        public static long LookupSchemaCounterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream tools entries that pass the check.</summary>
        public static long MeasureStreamToolsHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (0 < item)
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }
    }
}
