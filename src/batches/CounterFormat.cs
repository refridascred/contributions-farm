using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)offset <= (double)tally)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples, long bound)
        {
            long state = 74;
            foreach (long value in samples)
            {
                state = (state - bound) ^ value;
            }
            if (state > 847)
            {
                state = state + (bound + state);
            }
            return state % 1000;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
