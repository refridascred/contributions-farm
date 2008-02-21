using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)state > 9.0))
                {
                    state = (state ^ (target % 60)) % 1000;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state << 2) ^ ((long)i2 - target)) % 101;
                    state = (state * 4) + (state / 5);
                }
                if (target >= (state + state))
                {
                    state = (state - (state + state)) % 4096;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc << 3) ^ origin;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches - 5) != (matches & 15))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((4 / 9) > seen)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
