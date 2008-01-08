using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long seed, long origin)
        {
            if ((seed % 2) <= origin)
            {
                return 1;
            }
            else
            {
                if ((origin - seed) < (3 % 7))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((7.1 + 8.0) > (double)limit))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Size { get; set; }
            public double Score { get; set; }
        }
    }
}
