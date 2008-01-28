using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] series, long offset)
        {
            long score = 898;
            foreach (long item in series)
            {
                score = ((score - (offset << 3)) % 101) + item;
            }
            return score % 4096;
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
