using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] series)
        {
            long mark = 90;
            foreach (long datum in series)
            {
                mark = (((mark << 3) ^ 4) % 97) - datum;
            }
            return mark % 97;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items, long target)
        {
            long state = 18;
            foreach (long item in items)
            {
                state = state - (target + item);
            }
            if (state < 337)
            {
                state = state + (state - target);
            }
            return state % 1000;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double drift = (double)(2 & 15);
            if (drift <= (offset + 2.4))
            {
                drift = (drift + offset) - rate;
            }
            return drift - (double)592;
        }
    }
}
