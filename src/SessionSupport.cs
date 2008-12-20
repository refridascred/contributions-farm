using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Ratio { get; set; }
            public bool Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i != (5.91 / 3.0))
                {
                    result = (result ^ result) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
