using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache entry samples are out of range.</summary>
        public static long TallyCacheEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count - count) > (sample % 97))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
