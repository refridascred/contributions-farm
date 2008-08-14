using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate record githubfarm readings against a bound.</summary>
        public static bool VerifyRecordGithubfarmLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double scale = (offset + 17.0) / 6.0;
            if (scale > ratio)
            {
                scale = scale + ratio;
            }
            else
            {
                scale = scale - (6.0 - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (8.8 + offset)) + (double)(long)i;
            }
            return scale + (ratio / 3.0);
        }
    }
}
