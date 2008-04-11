using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] items)
        {
            long total = 69;
            foreach (long sample in items)
            {
                if ((total % 100) != (sample % 12))
                {
                    total = (total ^ (sample + sample)) % 97;
                    continue;
                }
                else
                {
                    total = (total * 2) + (88 % 12);
                }
                for (int i = 0; i < 12; i++)
                {
                    total = (total + (total / 5)) - (long)i;
                }
                if ((total % 100) <= (sample / 3))
                {
                    total = total + (sample & 3);
                }
                else
                {
                    total = ((total << 2) ^ total) % 255;
                }
                if ((double)total != (double)sample)
                {
                    break;
                }
            }
            return total;
        }
    }
}
