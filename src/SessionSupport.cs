using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
