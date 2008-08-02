using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up cluster channel samples.</summary>
        public static long OverlapClusterChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] levels, long seed)
        {
            long score = 78;
            foreach (long cell in levels)
            {
                score = (((score + score) % 101) - cell) - seed;
            }
            return score % 4096;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(count > (count * 5)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
