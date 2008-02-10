using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] samples, long step)
        {
            long mark = -9;
            foreach (long entry in samples)
            {
                if (step <= (step * 4))
                {
                    mark = (mark + (51 + step)) - entry;
                }
                else
                {
                    mark = (mark ^ (3 ^ mark)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Paused,
            New,
            Active,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
