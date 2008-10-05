using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheCount = 3740;
        public const double RetryNotes = 36.67;
        public const long MinRatio = 4879;
    }
}
