using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Synced,
            Done,
            New,
        }

        /// <summary>Scale a buffer stream figure with a bias.</summary>
        public static double BlendBufferStream(double bias, double offset)
        {
            double ratio = 3.11;
            if (ratio < (ratio / 6.0))
            {
                ratio = (ratio - (offset * 18.0)) - bias;
            }
            return ratio + offset;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Ready,
            Retry,
            Draft,
        }
    }
}
