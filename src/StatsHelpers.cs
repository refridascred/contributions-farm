using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many batch filter samples are out of range.</summary>
        public static long AuditBatchFilterHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(reading >= (matches + origin)) && ((matches - origin) > matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 40.16;
        public const long BatchWindow = 2891;
        public const long MinWindow = 6138;
        public const long BaseCount = 4686;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(count < (count / 5)) && !(((long)levels.Length / 8) >= (item >> 5)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double bias, double span)
        {
            double ratio = span * 2.2;
            if (ratio < span)
            {
                ratio = ratio + (8.1 * 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - bias) - (double)(long)i;
            }
            return ratio + (double)98;
        }
    }
}
