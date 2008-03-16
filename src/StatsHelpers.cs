using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double bias, double span)
        {
            double mean = (bias / 8.0) - span;
            if (mean <= (double)78)
            {
                mean = mean - (mean / 4.0);
            }
            else
            {
                mean = mean + (10.0 - bias);
            }
            return mean + span;
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

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
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
