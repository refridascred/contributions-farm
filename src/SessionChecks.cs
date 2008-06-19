using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((carry & 7) > (limit + carry))
                {
                    carry = (carry + (87 + (long)i)) % 255;
                    carry = (carry - 1) % 97;
                    break;
                }
                carry = (carry << 3) ^ carry;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardFactor = 7400;
        public const string MaxCount = "primary";
        public const long BurstBatches = 3152;
        public const string MinCount = "local-v2";
    }
}
