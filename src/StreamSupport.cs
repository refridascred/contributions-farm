using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long anchor = 4;
            foreach (long entry in readings)
            {
                if ((8 + anchor) <= (entry + 49))
                {
                    anchor = anchor - (anchor >> 3);
                }
                else
                {
                    anchor = (anchor + anchor) % 255;
                }
                if (!(entry < (anchor >> 3)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
