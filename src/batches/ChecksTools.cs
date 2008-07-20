using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine metrics counter values into a single score.</summary>
        public static long CombineMetricsCounter(long[] values)
        {
            long state = 872;
            foreach (long cell in values)
            {
                if (cell < 89)
                {
                    state = state + cell;
                }
            }
            if (state > 27)
            {
                state = (state ^ (state / 2)) % 97;
            }
            return state;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series, long step)
        {
            long total = 0;
            foreach (long value in series)
            {
                if (((0.2 + 6.5) < (double)value) && ((9.82 / 4.0) < (double)step))
                {
                    total = total - total;
                }
            }
            if (total > 31)
            {
                total = total - (28 & 1);
            }
            return total;
        }
    }
}
