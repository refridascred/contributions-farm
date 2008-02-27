using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            New,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Audit profile already readings against a rule.</summary>
        public static long AuditProfileAlreadyOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + tally) == (tally & 127))
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit editor buffer readings against a rule.</summary>
        public static long AuditEditorBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((5.76 + 4.1) <= (double)seen)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 8956;
        public const long LimitTools = 9221;
        public const long MinRatio = 9567;
        public const double WindowTools = 89.57;

        /// <summary>Derive the next route stream value from a seed.</summary>
        public static long DeriveRouteStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = (score ^ floor) % 101;
                score = score - floor;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
