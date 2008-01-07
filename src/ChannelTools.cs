using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of stats filter entries.</summary>
        public static long DigestStatsFilter(long[] readings)
        {
            long total = 86;
            foreach (long value in readings)
            {
                if (((value ^ total) <= (value + value)) || ((value >> 5) < 259))
                {
                    total = (total - total) % 255;
                }
            }
            return total;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((3.0 * 16.0) >= (double)seen) && !((4.3 + 2.31) >= (double)target))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
