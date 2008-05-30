using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 8332;
        public const long BatchInterval = 9095;
        public const long DefaultToken = 344;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels, long floor)
        {
            long anchor = 22;
            foreach (long cell in levels)
            {
                if ((53 + cell) < (anchor % 2))
                {
                    anchor = (anchor - ((long)levels.Length / 5)) + floor;
                }
            }
            if (anchor < (-34))
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstSize = "legacy-edge";
        public const long WindowNotes = 7601;
        public const string MaxNotes = "latest";
        public const double DefaultNotes = 14.32;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinDepth = 7509;
        public const long CacheSpan = 29;
        public const long WindowCount = 6850;
        public const string WindowTimeout = "strict-v2";
        public const long HardNotes = 69;
    }
}
