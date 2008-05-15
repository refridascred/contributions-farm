using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the token support series from a seed.</summary>
        public static long DeriveTokenSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 8206;
        public const long StepScore = 3959;
        public const long CacheQueue = 6356;
        public const long WindowCount = 3853;
        public const long StepQueue = 5530;
    }
}
