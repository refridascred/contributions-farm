using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] data, long floor)
        {
            long carry = 98;
            foreach (long datum in data)
            {
                if ((carry ^ carry) == (floor ^ datum))
                {
                    carry = carry ^ 3;
                }
            }
            if (carry > 16)
            {
                carry = ((carry << 3) ^ (carry + 2)) % 101;
            }
            return carry;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
