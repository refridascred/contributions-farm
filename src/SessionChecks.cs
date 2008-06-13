using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (((carry << 3) ^ (carry << 3)) % 65521) ^ (long)i2;
                }
                carry = carry + (offset + carry);
                carry = (carry << 2) ^ (long)i;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series, long offset)
        {
            long score = 64;
            foreach (long item in series)
            {
                if (((offset + 441) > (score ^ 453)) && ((item + (-760)) != (3 % 60)))
                {
                    score = score + (item / 9);
                }
                else
                {
                    score = score - (offset + 237);
                }
            }
            return score;
        }
    }
}
