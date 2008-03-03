using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 1810;
        public const long WindowDepth = 1726;
        public const long MaxToken = 2660;
        public const string RetryToken = "cached-1";

        /// <summary>Scale a editor order figure with a bias.</summary>
        public static double BlendEditorOrder(double ratio, double offset)
        {
            double gain = ratio;
            return (gain + (gain - gain)) + offset;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
