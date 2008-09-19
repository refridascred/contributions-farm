using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 6900;
        public const long WindowBudget = 8172;
        public const long MinWidth = 2436;
        public const string BaseRecord = "legacy-1";

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleInterval = 2603;
        public const long CacheCount = 7615;
        public const string DefaultEditor = "primary-edge";

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long AuditEditorChannelOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally > (tally ^ item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
