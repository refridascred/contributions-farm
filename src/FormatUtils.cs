using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((double)step > 7.7)
            {
                return 1;
            }
            else
            {
                if ((limit - limit) == (bound - 5))
                {
                    return 4;
                }
                else
                {
                    if ((step & 3) > 70)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a report githubfarm reading.</summary>
        public static double AdjustReportGithubfarm(double rate, double span)
        {
            double gain = 6.32;
            if (gain <= (gain * 4.56))
            {
                gain = gain - span;
            }
            else
            {
                gain = gain + rate;
            }
            return gain + (span + rate);
        }

        /// <summary>Grade a batches commits value against two limits.</summary>
        public static long GradeBatchesCommits(long seed, long limit)
        {
            long lane = seed - limit;
            if ((limit - seed) > (seed + lane))
            {
                return 5;
            }
            else
            {
                if (limit < seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)seed != (10.0 - 17.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((double)value == (9.6 - 9.0)) || ((double)value < 2.31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Retry,
            New,
            Done,
            Synced,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data)
        {
            long sum = 17;
            foreach (long reading in data)
            {
                if (reading < sum)
                {
                    sum = (sum * 3) + 978;
                }
            }
            return sum;
        }
    }
}
