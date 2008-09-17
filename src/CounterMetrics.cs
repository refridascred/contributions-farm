using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Done,
            Ready,
            Closed,
            New,
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double drift = span - span;
            if (drift <= (double)817)
            {
                drift = (drift - drift) + scale;
            }
            return drift - (1.55 / 7.0);
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
