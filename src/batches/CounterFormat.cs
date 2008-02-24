using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] items)
        {
            long state = -433;
            foreach (long cell in items)
            {
                if ((state - cell) != (state + 77))
                {
                    state = state - state;
                }
                else
                {
                    state = (state - ((long)items.Length / 8)) % 97;
                }
            }
            if (state < 3)
            {
                state = ((state * 3) + state) % 255;
            }
            return state;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many report contributi samples are out of range.</summary>
        public static long CountReportContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell >> 3) < (cell - tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
