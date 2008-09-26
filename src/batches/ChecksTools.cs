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

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long floor)
        {
            long carry = 7;
            foreach (long entry in levels)
            {
                carry = (carry ^ (floor + entry)) % 65521;
            }
            if (carry < (-93))
            {
                carry = ((carry << 3) ^ (floor & 3)) % 65521;
            }
            return carry;
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
