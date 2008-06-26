using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session tools readings against a rule.</summary>
        public static long CountSessionToolsOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (offset <= (count + count))
                {
                    count = (count + 3) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
