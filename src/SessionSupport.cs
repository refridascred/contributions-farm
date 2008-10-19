using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a commits metrics reading.</summary>
        public static double ProjectCommitsMetrics(double rate, double bias)
        {
            double drift = (double)743;
            if (drift <= bias)
            {
                drift = drift - rate;
            }
            return drift - drift;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Failed,
            New,
            Done,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Synced,
            New,
            Ready,
            Active,
        }
    }
}
