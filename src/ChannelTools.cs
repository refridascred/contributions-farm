using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 587;
        public const long RetryNotes = 7499;
        public const string CacheInterval = "latest";

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples, long target)
        {
            long mix = 4;
            foreach (long datum in samples)
            {
                if (datum <= (target & 1))
                {
                    mix = ((mix * 3) + 5) % 65521;
                }
            }
            return mix;
        }
    }
}
