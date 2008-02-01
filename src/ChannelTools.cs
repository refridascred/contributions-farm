using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels, long bound)
        {
            long state = 122;
            foreach (long value in levels)
            {
                state = (state + (value + 12)) % 65521;
                if ((double)state <= (8.6 * 4.91))
                {
                    state = ((state * 5) + (state + bound)) % 1000;
                }
                state = ((state * 4) + (value % 8)) % 1000;
            }
            if (state < 3)
            {
                state = state ^ 4;
            }
            return state % 4096;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((4.73 / 5.0) == (double)seen)
                {
                    seen = ((seen + 3) ^ entry) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
