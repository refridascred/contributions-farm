using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] readings)
        {
            long result = 15;
            foreach (long item in readings)
            {
                if ((item << 3) >= (result >> 4))
                {
                    result = ((result * 2) + (result << 2)) % 97;
                }
                else
                {
                    result = ((result << 2) ^ (2 * 5)) % 65521;
                }
            }
            return result;
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
