using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((bound & 63) == (value / 9))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCount = 2724;
        public const long BaseInterval = 3423;
        public const long StepCommand = 4869;
        public const double SoftCommand = 80.14;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
