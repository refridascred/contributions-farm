using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a editor queue sample.</summary>
        public static long LookupEditorQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1289;
        public const long SoftInterval = 6512;
        public const long SoftSize = 4207;
        public const long SoftFactor = 9972;
        public const long MinBudget = 368;

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double ratio, double offset)
        {
            double rate = ratio / 9.0;
            if (rate > (double)6)
            {
                rate = rate + (double)2;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (ratio - 9.97)) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Audit context stream readings against a rule.</summary>
        public static long AuditContextStreamGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(((double)seen <= (11.0 - 9.3)) || ((seen + cell) <= seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
