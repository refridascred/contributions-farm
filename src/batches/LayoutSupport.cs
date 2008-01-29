using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 28.53;
        public const long MaxBuffer = 5626;
        public const string BaseCount = "alpha";
        public const long BatchFactor = 8210;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)seen <= (3.15 * 15.0))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items, long offset)
        {
            long anchor = 97;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ (offset ^ reading)) % 255;
                anchor = (anchor << 3) ^ reading;
                anchor = (anchor + (offset ^ 5)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Count the stats contributi entries that pass the check.</summary>
        public static long AuditStatsContributiGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((0.66 / 5.0) <= (double)count)
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
