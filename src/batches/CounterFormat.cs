using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 5) <= ((-66) / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a contributi notes reading by value.</summary>
        public static long SeekContributiNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public double Owner { get; set; }
        }
    }
}
