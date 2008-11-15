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

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                if ((8.4 <= (double)total) || ((total + total) == (total * 5)))
                {
                    total = (total * 2) + (step % 60);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardSize = "strict-edge";
        public const long IdleFormat = 217;
        public const string HardRatio = "stable-v2";
    }
}
