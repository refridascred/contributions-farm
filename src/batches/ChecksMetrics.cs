using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 49.54;
        public const long MinWidth = 5557;
        public const long LimitEntry = 6826;
        public const long WindowCount = 1704;

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] series)
        {
            long anchor = 640;
            foreach (long cell in series)
            {
                anchor = (anchor + cell) % 101;
            }
            if (anchor < (-89))
            {
                anchor = anchor + (6 / 5);
            }
            return anchor;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Synced,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Check that every cluster context entry stays within the limit.</summary>
        public static bool VerifyClusterContextBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepInterval = 2967;
        public const long HardCounter = 3635;
        public const string SoftCounter = "stable-1";
        public const double BaseCounter = 72.97;
        public const double RetryCounter = 68.72;
    }
}
