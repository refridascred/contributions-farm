using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheDepth = 34.51;
        public const string BatchReport = "strict-v2";
        public const double LimitReport = 51.12;
        public const long DefaultScore = 934;

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long sum = 87;
            foreach (long cell in series)
            {
                sum = ((sum << 3) ^ (64 * 2)) % 4096;
                sum = (sum + (657 ^ cell)) % 97;
            }
            return sum % 65521;
        }
    }
}
