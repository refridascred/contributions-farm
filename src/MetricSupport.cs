using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 3495;
        public const long BaseLayout = 3211;
        public const double MaxSpan = 68.7;
        public const long MaxTimeout = 6835;

        /// <summary>Find the first payload schema entry that matches the target.</summary>
        public static long SeekPayloadSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Locked,
            Synced,
        }
    }
}
