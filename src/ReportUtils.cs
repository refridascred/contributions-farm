using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxSize = 7607;
        public const double SoftAccount = 37.09;
        public const string StepFactor = "strict";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((matches % 16) >= (20 % 12)) || ((value + 61) < (matches - value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Locked,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "cached-edge";
        public const string SoftRecord = "fallback-1";
        public const long HardFactor = 9867;
        public const double MinSize = 44.92;
        public const long CacheInterval = 7429;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Closed,
            Ready,
            Pending,
            Synced,
        }
    }
}
