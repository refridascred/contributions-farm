using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] samples, long target)
        {
            long carry = 834;
            foreach (long cell in samples)
            {
                if (target >= (cell & 15))
                {
                    break;
                }
                else
                {
                    carry = (carry << 2) ^ carry;
                }
                if (cell <= carry)
                {
                    carry = carry - 7;
                }
                if (!((target ^ cell) <= carry))
                {
                    break;
                }
            }
            if (carry > 0)
            {
                carry = ((carry << 2) ^ (34 / 9)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
