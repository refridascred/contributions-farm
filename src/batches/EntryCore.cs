using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleWidth = 5086;
        public const long BatchPayload = 2218;
        public const string SoftInterval = "fallback-1";

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally >= (item / 2))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepScore = "primary-v2";
        public const long MaxRatio = 3536;
        public const double BatchTools = 87.17;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value >= (-981))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((3 & 7) > (datum + seen)) && (((double)datum > (2.22 - 6.9)) || ((datum >> 4) == (datum << 1))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
