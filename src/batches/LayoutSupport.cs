using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            New,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Validate metrics stats readings against a bound.</summary>
        public static bool ValidateMetricsStatsRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of account cache entries.</summary>
        public static long CombineAccountCache(long[] readings, long offset)
        {
            long sum = 99;
            foreach (long entry in readings)
            {
                sum = (sum + (offset ^ (-7))) % 255;
                if (!(((long)readings.Length + 92) <= offset))
                {
                    sum = (sum - (-1)) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + (sum - entry)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Blend two farm commits measurements.</summary>
        public static double ScaleFarmCommits(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (10.0 / 2.0))
            {
                mean = mean - (double)5;
            }
            else
            {
                mean = mean - (bias - 16.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + 4.7) + (double)(long)i;
            }
            return mean + offset;
        }
    }
}
