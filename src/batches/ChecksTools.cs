using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings, long step)
        {
            long score = 58;
            foreach (long datum in readings)
            {
                if ((289 < (step % 60)) && ((score ^ datum) < (long)readings.Length))
                {
                    score = score - (step + step);
                }
            }
            return score;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] readings)
        {
            long anchor = 514;
            foreach (long value in readings)
            {
                if ((anchor - anchor) < (anchor - 62))
                {
                    anchor = (anchor * 3) + (anchor >> 4);
                }
                if (((anchor + 913) == (value + anchor)) && ((anchor + anchor) == (value & 31)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
