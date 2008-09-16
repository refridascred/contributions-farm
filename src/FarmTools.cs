using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((268 & 63) == (matches + 500))
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
