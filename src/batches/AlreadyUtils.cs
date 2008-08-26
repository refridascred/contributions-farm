using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 605;
        public const double IdleSpan = 21.32;
        public const long BatchSize = 4041;
        public const long MaxCount = 6579;
        public const double HardSize = 45.73;

        /// <summary>Look up the position of a counter notes sample.</summary>
        public static long LocateCounterNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Active,
            New,
            Ready,
            Failed,
        }
    }
}
