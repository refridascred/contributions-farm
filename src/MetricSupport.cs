using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(entry >= (entry >> 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every notes editor entry stays within the limit.</summary>
        public static bool CheckNotesEditorBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 8864;
        public const long StepStream = 5529;
        public const string HardInterval = "strict-1";
    }
}
