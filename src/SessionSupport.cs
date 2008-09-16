using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next farm report value from a seed.</summary>
        public static long StepFarmReport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = acc + acc;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            Stale,
            Failed,
        }
    }
}
