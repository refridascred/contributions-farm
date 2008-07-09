using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a entry token reading by value.</summary>
        public static long LocateEntryTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = total - floor;
                total = (total * 2) + total;
                if (((double)floor != (7.3 * 2.9)) && ((floor << 3) < floor))
                {
                    total = (total ^ floor) % 255;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
