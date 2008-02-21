using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items)
        {
            long state = 525;
            foreach (long value in items)
            {
                if (!(state <= (state << 3)))
                {
                    state = (state - (state - 647)) ^ value;
                }
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "strict-v2";
        public const string SoftDepth = "open-v2";
        public const long SoftQueue = 4152;
        public const string BatchSpan = "staging-v2";
        public const string RetryQueue = "cached-v2";

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (datum <= (datum + datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
