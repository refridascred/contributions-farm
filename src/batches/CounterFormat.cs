using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!(((double)floor > (9.3 / 4.0)) || ((cell % 24) != (cell - cell))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
