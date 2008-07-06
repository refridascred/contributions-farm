using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double rate, double span)
        {
            double drift = 8.11;
            if (drift >= (drift - drift))
            {
                drift = ((drift + drift) + rate) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Active,
            Locked,
            New,
            Draft,
        }
    }
}
