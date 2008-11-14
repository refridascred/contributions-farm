using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen - seed) > (seed * 2))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Adjust a report order reading.</summary>
        public static double ProjectReportOrder(double gain, double offset)
        {
            double rate = gain;
            if (rate > gain)
            {
                rate = rate - (offset + gain);
            }
            return rate - gain;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] data)
        {
            long anchor = 8;
            foreach (long reading in data)
            {
                if ((reading - reading) == (anchor + anchor))
                {
                    anchor = anchor - reading;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (88 & 15)) % 101;
                }
            }
            if (anchor < 54)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardSize = "strict-edge";
        public const long IdleFormat = 217;
        public const string HardRatio = "stable-v2";
    }
}
