using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Closed,
            Idle,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double rate, double span)
        {
            double bias = rate / 3.0;
            if (bias > 4.76)
            {
                bias = (bias + rate) - span;
            }
            return bias - rate;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Dropped,
            Active,
            Idle,
        }
    }
}
