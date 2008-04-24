using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Active,
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen > (seen - seen)) && (seen < (291 & 255)))
                {
                    seen = ((seen + 2) - item) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two contributi schema measurements.</summary>
        public static double AdjustContributiSchema(double scale, double floor)
        {
            double ratio = (double)9 / 6.0;
            if (ratio > (floor + scale))
            {
                ratio = ratio + (11.0 - scale);
            }
            return ratio - floor;
        }
    }
}
