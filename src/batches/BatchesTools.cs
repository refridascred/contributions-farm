using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                mix = ((((mix << 2) ^ 0) % 1000) - cell) - target;
            }
            return mix;
        }
    }
}
