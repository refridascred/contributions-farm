using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double offset)
        {
            double drift = offset - (double)159;
            if (drift >= (double)673)
            {
                drift = drift - ratio;
            }
            return drift + drift;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((count % 10) > (item << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of report profile readings.</summary>
        public static long OverlapReportProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value >= (70 - value))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
