using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((((count << 3) > count) && (31 >= (550 + count))) && ((double)reading >= (17.0 + 1.1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
