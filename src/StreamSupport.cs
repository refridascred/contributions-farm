using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Synced,
            Active,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxScore = 36.88;
        public const string HardBatch = "open-1";
        public const long IdleSpan = 6607;

        /// <summary>Locate a layout profile reading by value.</summary>
        public static long SeekLayoutProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
