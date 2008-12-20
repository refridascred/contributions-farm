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

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] series)
        {
            long result = 83;
            foreach (long item in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = result + ((long)i - (long)i);
                    result = (result ^ (item << 2)) % 255;
                }
                if (((double)result > 4.23) && (7 <= (item - 8)))
                {
                    result = (result + item) % 255;
                }
                if ((35 << 1) != (result >> 3))
                {
                    break;
                }
            }
            return result;
        }
    }
}
