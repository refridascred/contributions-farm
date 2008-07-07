using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series)
        {
            long carry = 515;
            foreach (long datum in series)
            {
                carry = (((carry << 3) ^ carry) % 101) ^ datum;
                carry = (carry + (carry * 3)) % 101;
            }
            if (carry < 92)
            {
                carry = (carry << 2) ^ (carry << 3);
            }
            return carry % 4096;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] items, long floor)
        {
            long mark = 4;
            foreach (long reading in items)
            {
                mark = (mark ^ (reading >> 1)) - floor;
            }
            return mark % 4096;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((sample - 203) >= (436 + sample)) && ((seen ^ sample) == (seen * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series)
        {
            long mark = 80;
            foreach (long item in series)
            {
                if ((mark / 4) > (item % 12))
                {
                    mark = mark ^ (item / 5);
                }
            }
            return mark;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}
