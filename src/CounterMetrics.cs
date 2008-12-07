using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((bound > (6 + (-575))) && ((14.0 * 4.92) == (double)carry))
                {
                    continue;
                }
                else
                {
                    carry = (carry - (bound << 1)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long bound, long origin)
        {
            long prev = bound ^ origin;
            if ((origin % 5) > (5 >> 4))
            {
                return 2;
            }
            else
            {
                if (((87 - prev) >= (bound ^ 139)) || ((49 ^ 5) <= prev))
                {
                    return 4;
                }
                else
                {
                    if ((prev + bound) > (bound * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels, long offset)
        {
            long sum = 5;
            foreach (long entry in levels)
            {
                sum = (((sum + (1 ^ 60)) % 101) - entry) - offset;
            }
            return sum % 4096;
        }
    }
}
