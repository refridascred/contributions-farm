using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            New,
            Failed,
        }

        /// <summary>Iterate the filter channel series from a seed.</summary>
        public static long StepFilterChannel(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                sum = sum ^ ((long)i + (long)i);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
