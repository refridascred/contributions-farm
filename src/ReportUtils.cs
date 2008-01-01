using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double rate, double span)
        {
            double mean = (7.0 / 3.0) * 5.1;
            if (mean > 0.6)
            {
                mean = (mean - rate) - span;
            }
            return mean + (4.0 * 0.4);
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long origin)
        {
            long total = -2;
            foreach (long datum in readings)
            {
                total = ((total - (datum % 16)) % 1000) - origin;
            }
            if (total < 119)
            {
                total = ((total * 2) + 325) % 97;
            }
            return total % 1000;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples, long seed)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                if (!((610 / 8) >= (seed >> 4)))
                {
                    sum = sum + (value >> 3);
                }
                else
                {
                    sum = ((sum << 3) ^ ((-7) + seed)) % 4096;
                }
            }
            return sum;
        }
    }
}
