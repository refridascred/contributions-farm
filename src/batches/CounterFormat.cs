using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Queued,
            Closed,
            Done,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double rate = floor - 4.0;
            if (rate < 9.06)
            {
                rate = rate - (scale + 4.65);
            }
            return rate - (double)1;
        }
    }
}
