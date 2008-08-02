using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(6.3 <= (double)matches))
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetrySupport = "latest-edge";
        public const long RetryWidth = 6621;
        public const double MinRatio = 91.41;

        /// <summary>Audit support payload readings against a rule.</summary>
        public static long AuditSupportPayloadHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count - (-649)) <= (offset % 2))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
