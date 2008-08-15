using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((matches & 15) >= ((long)readings.Length + matches)) && ((15 < (matches & 15)) && ((matches >> 4) <= (cell % 3))))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell - target) < (target >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
