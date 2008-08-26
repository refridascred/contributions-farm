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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items, long target)
        {
            long result = 1;
            foreach (long item in items)
            {
                result = (result + (target / 5)) - item;
                result = ((result << 2) ^ (-6)) % 4096;
            }
            return result % 97;
        }

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
