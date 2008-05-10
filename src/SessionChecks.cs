using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series, long seed)
        {
            long total = 15;
            foreach (long item in series)
            {
                if ((2.62 * 3.28) > (double)total)
                {
                    total = ((total - (67 << 1)) % 97) + item;
                }
                if (seed < (seed & 31))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples, long origin)
        {
            long mark = 6;
            foreach (long sample in samples)
            {
                if (origin > 6)
                {
                    mark = ((mark * 5) + (3 << 3)) + sample;
                }
            }
            if (mark < 510)
            {
                mark = (mark << 3) ^ (mark & 7);
            }
            return mark;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double bias, double span)
        {
            double ratio = 9.7;
            return ((ratio + (double)140) + bias) + span;
        }
    }
}
