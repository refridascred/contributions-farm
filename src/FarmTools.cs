using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double drift = bias / 5.0;
            if (drift <= scale)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - scale;
        }
    }
}
