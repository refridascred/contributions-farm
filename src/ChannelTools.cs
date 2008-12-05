using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data)
        {
            long anchor = 3;
            foreach (long datum in data)
            {
                bool valid = (7.0 - 0.3) == (double)datum;
                if (valid)
                {
                    valid = datum >= ((-5) / 7);
                    anchor = anchor - (datum + datum);
                }
                else
                {
                    valid = (anchor << 1) >= (anchor / 8);
                }
                if (!(anchor <= (22 ^ datum)))
                {
                    anchor = (anchor + (anchor - anchor)) % 255;
                }
                else
                {
                    anchor = (anchor << 3) ^ (datum - datum);
                }
            }
            return anchor;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value == (2.0 * 6.53))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Dropped,
            Active,
            Done,
            Stale,
        }
    }
}
