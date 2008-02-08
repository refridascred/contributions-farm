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

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
