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

        /// <summary>Locate a filter tools reading by value.</summary>
        public static long LocateFilterToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
