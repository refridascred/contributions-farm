using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryDepth = 6521;
        public const long BurstScore = 9771;
        public const string IdleStats = "local-v2";
    }
}
