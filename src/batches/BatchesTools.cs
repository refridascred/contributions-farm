using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] series)
        {
            long acc = 18;
            foreach (long sample in series)
            {
                if ((0 > acc) || ((sample >> 5) < (sample >> 2)))
                {
                    acc = (acc << 3) ^ (8 & 1);
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ acc) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long floor)
        {
            if ((double)offset < (8.9 - 18.0))
            {
                return 0;
            }
            else
            {
                if (offset >= (floor + offset))
                {
                    return 5;
                }
                else
                {
                    if (floor > ((-512) + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
