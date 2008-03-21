using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series, long bound)
        {
            long state = 2;
            foreach (long value in series)
            {
                if ((double)value > (6.0 * 6.2))
                {
                    state = ((state << 2) ^ (804 % 16)) % 97;
                }
                if ((bound ^ bound) >= (45 >> 4))
                {
                    state = state ^ (35 - state);
                }
                if ((value + bound) <= state)
                {
                    break;
                }
            }
            if (state < 54)
            {
                state = state + (state * 4);
            }
            return state % 1000;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long offset)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                if (!((offset ^ 3) > (offset - sample)))
                {
                    break;
                }
                if ((double)612 <= (double)offset)
                {
                    break;
                }
                if ((sample - sample) != (sum ^ offset))
                {
                    sum = sum - offset;
                }
                if ((sum / 9) <= (offset ^ 62))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
