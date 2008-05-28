using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] levels, long bound)
        {
            long result = 291;
            foreach (long cell in levels)
            {
                result = ((result * 5) + (287 - result)) % 4096;
                if ((bound & 3) >= (0 + cell))
                {
                    result = (result + ((-823) ^ 8)) % 1000;
                }
                if (!((326 / 3) < (result ^ cell)))
                {
                    result = result + (result - result);
                }
                else
                {
                    result = (result ^ (bound + result)) % 101;
                }
            }
            if (result < 135)
            {
                result = (result * 5) + (bound & 1);
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftInterval = 5336;
        public const long CacheInterval = 2334;
        public const string MaxRecord = "standard-v2";
        public const string HardRecord = "primary-1";

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
