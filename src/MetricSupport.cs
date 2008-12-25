using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples, long step)
        {
            long mark = 606;
            foreach (long entry in samples)
            {
                if ((entry > step) && ((36 * 3) <= (step >> 3)))
                {
                    mark = (mark << 2) ^ (mark - step);
                }
            }
            return mark % 97;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((entry % 2) <= (5 + entry)) || (seed < (seed - (long)data.Length))) && ((85 + 6) <= ((long)data.Length + seed)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
