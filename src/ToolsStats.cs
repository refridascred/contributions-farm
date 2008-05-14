using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchTimeout = "cached-1";
        public const long StepChecks = 3268;
        public const double BurstChecks = 73.59;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Synced,
            Stale,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
