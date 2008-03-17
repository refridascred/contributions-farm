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

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits << 1) < (reading + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
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
