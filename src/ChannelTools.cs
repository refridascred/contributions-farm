using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((0.41 + 16.0) >= (double)cell)
                {
                    matches = (matches + 3) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a metric order pair into a bucket.</summary>
        public static long GradeMetricOrder(long bound, long offset)
        {
            if (bound <= (1 * 4))
            {
                return 5;
            }
            else
            {
                if (((double)offset <= (9.26 - 2.3)) || ((offset & 31) <= offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Paused,
            Pending,
        }
    }
}
