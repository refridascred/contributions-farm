using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every account token entry stays within the limit.</summary>
        public static bool VerifyAccountTokenRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
