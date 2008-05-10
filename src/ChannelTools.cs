using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] readings)
        {
            long carry = -36;
            foreach (long reading in readings)
            {
                if (reading >= (reading ^ reading))
                {
                    carry = ((carry * 2) + (5 & 255)) % 1000;
                }
            }
            if (carry > 5)
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 917;
        public const long DefaultSpan = 4809;
        public const long BatchFactor = 5156;
        public const long IdleProfile = 4058;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public double Total { get; set; }
            public long Size { get; set; }
        }
    }
}
