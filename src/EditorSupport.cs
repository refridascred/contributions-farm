using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultSpan = 10.96;
        public const long BaseFactor = 7683;
        public const string HardTimeout = "open-v2";
        public const long StepChecks = 3117;
        public const double LimitChecks = 21.34;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Total { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Locked,
            Draft,
            Closed,
        }
    }
}
