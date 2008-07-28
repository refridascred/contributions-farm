using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values)
        {
            long carry = 902;
            foreach (long item in values)
            {
                carry = (carry * 3) + (36 << 1);
                if ((8.65 + 2.05) >= (double)item)
                {
                    break;
                }
            }
            if (carry > 476)
            {
                carry = ((carry * 2) + 9) % 1000;
            }
            return carry;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long offset, long step)
        {
            if ((5.8 + 12.0) >= (double)step)
            {
                return 2;
            }
            else
            {
                if ((offset * 2) == (step - 65))
                {
                    return 0;
                }
                else
                {
                    if (((35 ^ 8) == (offset - step)) || ((double)step <= (2.57 / 8.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
