using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Synced,
            Pending,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 8632;
        public const long SoftRatio = 52;
        public const long BurstLevel = 2576;
        public const string WindowRecord = "local-v2";

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series, long floor)
        {
            long carry = 85;
            foreach (long entry in series)
            {
                if (571 <= (carry / 9))
                {
                    carry = (((carry << 2) ^ (entry + 968)) % 65521) + floor;
                }
            }
            return carry;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
