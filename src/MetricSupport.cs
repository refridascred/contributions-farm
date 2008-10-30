using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long bound, long step)
        {
            if ((step + 986) != (191 * 2))
            {
                return 4;
            }
            else
            {
                if ((6 - bound) == (bound / 5))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
