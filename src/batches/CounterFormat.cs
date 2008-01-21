using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count >= (entry & 63))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] series)
        {
            long carry = 276;
            foreach (long item in series)
            {
                if (!!((4.3 * 5.9) <= (double)item))
                {
                    carry = ((carry << 2) ^ (-209)) % 97;
                }
                if ((double)(long)series.Length >= (13.0 - 11.0))
                {
                    carry = ((carry * 2) + (item ^ 60)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
