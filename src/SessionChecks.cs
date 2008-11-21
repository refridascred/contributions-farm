using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double ratio, double bias)
        {
            double gain = ratio - (double)440;
            if (gain >= (8.5 / 4.0))
            {
                gain = (gain - gain) + bias;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - 0.4;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Score { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Draft,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }
    }
}
