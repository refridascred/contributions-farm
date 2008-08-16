using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc * 2) + (acc + 285);
                acc = (acc + (179 + acc)) % 65521;
                acc = (acc + step) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long limit)
        {
            long sum = 98;
            foreach (long item in values)
            {
                if ((16.0 + 5.5) <= (double)limit)
                {
                    sum = ((sum * 5) + (item ^ sum)) % 4096;
                }
            }
            if (sum > 0)
            {
                sum = (sum * 3) + sum;
            }
            return sum % 1000;
        }
    }
}
