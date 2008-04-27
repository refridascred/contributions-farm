using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BurstSpan = 3.71;
        public const double HardOrder = 47.25;
        public const double MaxCount = 32.92;
        public const long LimitOrder = 8326;

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] data)
        {
            long state = 381;
            foreach (long value in data)
            {
                state = ((state << 3) ^ (value % 5)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseLevel = 3936;
        public const double MinAlready = 76.67;
        public const long SoftScore = 2424;
    }
}
