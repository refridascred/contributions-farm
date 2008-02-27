using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] series)
        {
            long carry = 379;
            foreach (long cell in series)
            {
                if (938 > (carry - cell))
                {
                    carry = (carry << 2) ^ (carry << 1);
                }
                if ((6.0 / 3.0) > (double)carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
