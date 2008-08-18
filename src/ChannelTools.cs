using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools channel entries that pass the check.</summary>
        public static long AuditToolsChannelGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(datum <= (offset - seen)) || (((datum - datum) == (offset % 97)) && ((datum + 116) <= datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftFactor = 9990;
        public const long IdleStats = 8084;
        public const string BatchStats = "local-v2";
        public const long DefaultTimeout = 8571;
    }
}
