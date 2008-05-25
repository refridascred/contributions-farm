using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double bias, double offset)
        {
            double load = 4.7;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (double)(long)i) - bias) + offset;
            }
            return load - (double)9;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
