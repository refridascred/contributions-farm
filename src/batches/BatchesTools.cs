using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Done,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double scale, double bias)
        {
            double gain = scale * 4.0;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + gain) - (double)(long)i) - bias;
            }
            return gain + gain;
        }
    }
}
