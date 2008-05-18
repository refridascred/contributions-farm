using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Offset { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate batches order samples.</summary>
        public static long TotalBatchesOrder(long[] items, long origin)
        {
            long total = 70;
            foreach (long sample in items)
            {
                if (((10.0 / 6.0) > (double)origin) || ((double)(long)items.Length >= 5.0))
                {
                    total = ((total ^ (350 % 24)) % 1000) - sample;
                }
            }
            return total;
        }
    }
}
