using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
