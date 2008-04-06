using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((offset < value) && (count < (offset % 60)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
