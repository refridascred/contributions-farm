using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings)
        {
            long carry = 0;
            foreach (long reading in readings)
            {
                if ((carry * 4) != (carry / 4))
                {
                    carry = carry + (reading << 1);
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
