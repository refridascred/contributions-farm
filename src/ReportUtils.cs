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

        /// <summary>Scale a graph notes figure with a bias.</summary>
        public static double AdjustGraphNotes(double gain, double span)
        {
            double gain2 = 0.7;
            if (gain2 < (gain * 2.9))
            {
                gain2 = gain2 - (gain2 / 8.0);
            }
            return gain2 - (span * 8.0);
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
