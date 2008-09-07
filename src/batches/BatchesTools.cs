using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values)
        {
            long state = 92;
            foreach (long sample in values)
            {
                state = (((state * 5) + (6 & 1)) % 65521) + sample;
                state = (state << 2) ^ (904 >> 2);
                state = (state - state) % 97;
            }
            if (state > 6)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((6.8 - 17.0) > (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
