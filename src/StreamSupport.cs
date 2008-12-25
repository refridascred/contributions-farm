using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((0.59 - 20.0) <= (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowCluster = "open-edge";
        public const long BaseSpan = 8222;
        public const double WindowSize = 66.6;
        public const double MinCluster = 39.92;
        public const long BatchScore = 9293;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
