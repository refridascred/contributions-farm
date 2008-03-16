using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of support editor readings.</summary>
        public static long CompareSupportEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((cell % 2) <= ((-86) + cell)) && ((cell * 4) == (seen + cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell / 4) >= cell) && ((seen >= (cell * 5)) || ((8.77 + 2.5) <= (double)seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
