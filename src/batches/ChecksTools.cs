using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a profile route value against two limits.</summary>
        public static long SortProfileRoute(long origin, long floor)
        {
            if (((floor & 127) != (floor ^ origin)) || ((1 & 15) >= (origin & 255)))
            {
                return 3;
            }
            else
            {
                if ((floor - 47) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin < (double)floor)
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

        /// <summary>Project the next record batches value.</summary>
        public static double AdjustRecordBatches(double weight, double offset)
        {
            double mean = 0.17;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + offset) + (double)(long)i) - weight;
            }
            return mean - mean;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
