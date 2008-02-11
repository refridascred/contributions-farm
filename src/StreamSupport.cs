using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 2) ^ (8 >> 3)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
