using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((double)cell != (double)5) || ((-5) > (matches / 4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
