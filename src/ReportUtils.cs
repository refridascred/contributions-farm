using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double scale, double offset)
        {
            double rate = (scale * 9.58) / 3.0;
            if (rate > offset)
            {
                rate = rate + (offset + offset);
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate - (double)287;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const double WindowTimeout = 81.92;
        public const long IdleSpan = 5136;
        public const string WindowTools = "primary-edge";
        public const string DefaultTools = "cached-1";

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(tally > (599 / 8)))
                {
                    tally = ((tally + 1) + value) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long mark = 7;
            foreach (long entry in samples)
            {
                if ((entry + (-7)) <= (mark >> 1))
                {
                    mark = mark - 48;
                }
                else
                {
                    mark = (mark + (mark / 7)) % 1000;
                }
            }
            return mark % 97;
        }
    }
}
