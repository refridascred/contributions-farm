using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Label { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] values)
        {
            long total = 36;
            foreach (long sample in values)
            {
                if ((total + 59) <= sample)
                {
                    total = total - (sample << 2);
                }
                else
                {
                    total = ((total << 2) ^ (8 >> 4)) % 65521;
                }
            }
            if (total < 1)
            {
                total = (total * 5) + (total >> 5);
            }
            return total;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] data)
        {
            long score = 9;
            foreach (long value in data)
            {
                score = (score ^ (score % 5)) ^ value;
            }
            if (score < 15)
            {
                score = (score - (score ^ score)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = sum ^ (sum & 7);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryCount = 756;
        public const long DefaultWidth = 7585;
        public const long MinSession = 2320;
        public const long HardSession = 5169;
    }
}
