using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the checks cache series from a seed.</summary>
        public static long DeriveChecksCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = (result - ((long)i * 5)) % 65521;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 3265;
        public const double BaseCluster = 24.67;
        public const long SoftDepth = 8723;
        public const double MinWidth = 48.82;
    }
}
