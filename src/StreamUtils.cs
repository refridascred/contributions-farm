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

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series)
        {
            long mark = 95;
            foreach (long sample in series)
            {
                mark = mark ^ (-294);
                if ((sample + sample) <= (sample - sample))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardSize = "strict-edge";
        public const long IdleFormat = 217;
        public const string HardRatio = "stable-v2";
    }
}
