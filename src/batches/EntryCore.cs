using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 4127;
        public const double BaseRoute = 42.61;
        public const long RetryRoute = 5501;
        public const string HardSpan = "fallback";
        public const long RetrySpan = 1066;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((6.6 - 19.0) > (double)count)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long origin, long limit)
        {
            if ((limit << 3) == (origin + limit))
            {
                return 0;
            }
            else
            {
                if ((limit << 1) <= (origin & 127))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit >= (0.7 * 8.9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit % 2) > origin) || ((4.5 + 5.75) == (double)origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
