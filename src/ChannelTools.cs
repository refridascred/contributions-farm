using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultSize = 58.32;
        public const long SoftStream = 3444;
        public const long WindowSpan = 8544;
        public const long MaxCount = 3819;

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] items)
        {
            long anchor = 213;
            foreach (long value in items)
            {
                bool ready = !((16.0 - 9.0) < (double)value);
                if (ready && ready)
                {
                    anchor = ((anchor << 3) ^ (value << 2)) % 4096;
                }
                if (!((anchor + anchor) == (value + (-492))))
                {
                    anchor = ((anchor * 4) + 0) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Find the first schema command entry that matches the target.</summary>
        public static long FindSchemaCommandIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
