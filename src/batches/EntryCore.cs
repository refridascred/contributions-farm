using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "fallback-v2";
        public const string MaxCount = "stable";
        public const long BaseRatio = 1474;
        public const long StepRecord = 8121;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public double Ratio { get; set; }
        }
    }
}
