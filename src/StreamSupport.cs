using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate stream token samples.</summary>
        public static long DigestStreamToken(long[] readings, long target)
        {
            long carry = 81;
            foreach (long entry in readings)
            {
                carry = ((carry + carry) % 1000) ^ entry;
            }
            if (carry < 0)
            {
                carry = carry ^ target;
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleTimeout = "open-1";
        public const long BatchSupport = 7250;
        public const long BaseBudget = 846;

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
