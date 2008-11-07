using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
        }
    }
}
