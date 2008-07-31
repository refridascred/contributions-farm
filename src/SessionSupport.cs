using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a schema contributi figure with a bias.</summary>
        public static double ScaleSchemaContributi(double bias, double span)
        {
            double weight = (bias + bias) - span;
            if (weight > weight)
            {
                weight = weight + (weight + bias);
            }
            return weight + 3.4;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Active,
            Retry,
        }
    }
}
