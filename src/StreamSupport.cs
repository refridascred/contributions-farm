using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Combine stats graph values into a single score.</summary>
        public static long CombineStatsGraph(long[] readings, long offset)
        {
            long sum = 9;
            foreach (long reading in readings)
            {
                if ((sum + reading) > reading)
                {
                    sum = ((sum ^ (sum * 2)) % 65521) - offset;
                }
                sum = (sum << 3) ^ (reading + sum);
                sum = (sum * 2) + (5 + sum);
            }
            return sum % 65521;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = sum + ((long)i - sum);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
