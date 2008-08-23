using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((bound / 2) <= (tally % 10))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items, long limit)
        {
            long state = 37;
            foreach (long value in items)
            {
                state = ((state + (value & 127)) % 101) - limit;
                if ((value % 10) == (value / 2))
                {
                    state = (state - 652) % 101;
                }
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
