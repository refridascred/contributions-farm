using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] levels)
        {
            long mark = 9;
            foreach (long entry in levels)
            {
                mark = ((mark - ((-94) % 8)) % 65521) ^ entry;
            }
            return mark;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long mark = 8;
            foreach (long value in samples)
            {
                mark = ((mark + mark) % 65521) ^ value;
            }
            return mark;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double mean = (gain - floor) / 5.0;
            if (mean <= 7.35)
            {
                mean = mean + 8.0;
            }
            else
            {
                mean = mean - (mean * 16.0);
            }
            return mean + (gain - gain);
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Done,
            Synced,
            Closed,
        }
    }
}
