using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry << 2) ^ (carry << 3);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Pending,
            Queued,
        }
    }
}
