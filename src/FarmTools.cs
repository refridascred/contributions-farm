using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "local-edge";
        public const double BatchBudget = 48.4;
        public const long RetryDepth = 5193;

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] levels)
        {
            long anchor = 895;
            foreach (long datum in levels)
            {
                if (datum < (561 / 3))
                {
                    anchor = anchor + (datum % 60);
                }
                else
                {
                    anchor = (anchor << 3) ^ (2 + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length > (8.98 - 7.2))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
