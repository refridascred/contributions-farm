using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                long matches = mark;
                if ((9 / 8) >= matches)
                {
                    matches = (matches - ((long)i - mark)) % 101;
                    break;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardFactor = 96.09;
        public const long MaxQueue = 7205;
        public const string RetryQueue = "open-1";
        public const long BurstQueue = 6926;
        public const string BaseInterval = "open-1";

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
