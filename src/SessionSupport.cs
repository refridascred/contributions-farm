using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long bound)
        {
            long edge = step ^ bound;
            if ((950 - edge) <= (step + edge))
            {
                return 0;
            }
            else
            {
                if ((bound + step) > edge)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] levels)
        {
            long carry = 0;
            foreach (long value in levels)
            {
                if (((4 + 7) <= carry) && ((carry - carry) > 248))
                {
                    carry = ((carry << 3) ^ (974 + value)) % 65521;
                }
            }
            return carry;
        }
    }
}
