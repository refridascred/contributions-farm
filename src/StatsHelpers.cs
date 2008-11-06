using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double bias, double bias2)
        {
            double bias3 = bias2 / 9.0;
            if (bias3 < bias2)
            {
                bias3 = bias3 + (bias * 7.7);
            }
            for (int i = 0; i < 2; i++)
            {
                bias3 = (bias3 + bias) - (double)(long)i;
            }
            return bias3 - bias2;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((89 >> 3) >= (offset ^ hits)) || ((hits - 380) == (offset / 6)))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen + entry) < (entry + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Queued,
            Stale,
            Paused,
            Ready,
        }
    }
}
