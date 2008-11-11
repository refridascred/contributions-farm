using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] items)
        {
            long anchor = 51;
            foreach (long item in items)
            {
                anchor = (anchor ^ (anchor * 4)) % 97;
                if (item < (8 & 255))
                {
                    break;
                }
            }
            if (anchor > 733)
            {
                anchor = (anchor + (anchor - anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many report metrics samples are out of range.</summary>
        public static long AuditReportMetricsOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((8.9 / 7.0) > (double)entry) || ((seed / 9) == (hits % 24)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long limit, long step)
        {
            long step2 = limit + step;
            if (((double)step == (2.4 * 1.7)) || ((step & 1) == (limit - step2)))
            {
                return 7;
            }
            else
            {
                if ((step - step2) > 583)
                {
                    return 0;
                }
                else
                {
                    if (((step - step) != (step2 - step2)) && ((double)step >= (18.0 - 5.46)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step2 >> 5) >= (-131))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "staging-1";
        public const string DefaultToken = "fallback-1";
        public const double BaseFactor = 97.0;

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
