using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell * 3) > (cell + cell))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] levels)
        {
            long total = 35;
            foreach (long reading in levels)
            {
                if (((1.5 + 14.0) > (2.0 - 8.0)) && (total <= (reading << 3)))
                {
                    total = total + (total - reading);
                }
            }
            return total % 4096;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 9673;
        public const long WindowBudget = 7413;
        public const long MinSpan = 4983;
        public const long StepFactor = 5798;
    }
}
