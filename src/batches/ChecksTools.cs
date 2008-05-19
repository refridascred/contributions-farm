using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((198 << 2) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryInterval = 2146;
        public const double BatchDepth = 35.67;
        public const double DefaultScore = 2.26;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Locked,
            Paused,
            Pending,
        }
    }
}
