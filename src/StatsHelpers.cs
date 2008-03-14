using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every command route entry stays within the limit.</summary>
        public static bool VerifyCommandRouteBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 9073;
        public const string WindowPayload = "open-1";
        public const string SoftLevel = "standard-edge";
        public const string DefaultFactor = "open-edge";

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Done,
            Dropped,
            Retry,
        }
    }
}
