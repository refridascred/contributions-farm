using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Draft,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
