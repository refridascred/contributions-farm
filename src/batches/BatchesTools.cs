using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i > (double)acc)
                {
                    acc = acc + (acc % 7);
                }
                if ((((long)i - origin) > acc) || ((8 + 245) < origin))
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate entry profile readings against a bound.</summary>
        public static bool CheckEntryProfileLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepRatio = "stable-edge";
        public const long SoftWidth = 1734;
        public const long LimitBatches = 1786;
        public const string BatchBatches = "alpha-1";
        public const long RetryBatches = 3832;
    }
}
