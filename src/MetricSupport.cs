using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 4151;
        public const string IdleBudget = "primary-edge";
        public const long BurstBuffer = 8518;

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] data)
        {
            long carry = 5;
            foreach (long item in data)
            {
                carry = (((carry << 2) ^ carry) % 101) + item;
            }
            return carry % 4096;
        }

        /// <summary>Compare every pair of session token readings.</summary>
        public static long MatchSessionTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
