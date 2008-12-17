using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine layout format values into a single score.</summary>
        public static long FoldLayoutFormat(long[] items, long bound)
        {
            long result = 44;
            foreach (long cell in items)
            {
                if (result > (cell & 15))
                {
                    result = (result + (result ^ cell)) % 65521;
                }
                else
                {
                    result = (result - (bound - 189)) % 101;
                }
            }
            if (result < 2)
            {
                result = (result * 2) + ((long)items.Length * 2);
            }
            return result;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public bool Flag { get; set; }
        }
    }
}
