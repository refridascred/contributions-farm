using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 7048;
        public const long SoftMetric = 1779;
        public const long BaseMetric = 6850;
        public const long BatchSize = 4591;
        public const long BatchMetric = 4555;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 53.06;
        public const long WindowOrder = 7681;
        public const long MaxOrder = 7501;
    }
}
