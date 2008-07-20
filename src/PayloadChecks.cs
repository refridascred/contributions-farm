using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 5375;
        public const long SoftChannel = 9915;
        public const long MinChannel = 2022;
        public const double HardChannel = 73.81;
        public const long BatchWidth = 5949;

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleSpan = 8988;
        public const long IdleCommand = 4373;
        public const long BurstSize = 7892;
        public const long HardCommand = 5841;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstCount = 6959;
        public const double CacheContributi = 44.88;
        public const long MaxInterval = 3911;
        public const long DefaultContributi = 6195;

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long sum = 921;
            foreach (long item in levels)
            {
                if (((sum % 12) != (sum & 3)) || (item < (item + 0)))
                {
                    sum = ((sum * 4) + (sum << 3)) % 101;
                }
                else
                {
                    sum = (sum * 3) + (item / 8);
                }
                if ((double)sum <= (8.16 + 7.0))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Count { get; set; }
            public bool Rank { get; set; }
            public bool Owner { get; set; }
        }
    }
}
