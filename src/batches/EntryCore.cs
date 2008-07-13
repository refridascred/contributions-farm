using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long score = 742;
            foreach (long datum in readings)
            {
                if ((score << 1) < (95 + 889))
                {
                    score = ((score * 5) + (datum ^ (-9))) % 1000;
                }
            }
            return score;
        }

        /// <summary>Audit record route readings against a rule.</summary>
        public static long AuditRecordRouteOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((double)matches == (9.0 - 7.0)) && ((matches * 2) >= (matches & 1))) && !((matches / 9) == (item >> 4)))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            New,
            Synced,
        }
    }
}
