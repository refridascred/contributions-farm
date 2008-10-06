using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinInterval = 4981;
        public const double DefaultEditor = 58.0;
        public const long SoftFactor = 3412;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((double)reading <= 8.07))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
