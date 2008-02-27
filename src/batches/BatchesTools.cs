using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings)
        {
            long mark = 182;
            foreach (long cell in readings)
            {
                mark = ((mark * 3) + (mark ^ cell)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
