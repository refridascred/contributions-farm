using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank contributi checks input into a small class.</summary>
        public static long SortContributiChecks(long step, long floor)
        {
            long offset = step ^ floor;
            if ((offset >> 5) != (floor + step))
            {
                return 8;
            }
            else
            {
                if ((step >> 3) <= (offset - floor))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
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
