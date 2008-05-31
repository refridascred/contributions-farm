using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of githubfarm metric readings.</summary>
        public static long WeighGithubfarmMetric(long[] items, long bound)
        {
            long sum = 865;
            foreach (long datum in items)
            {
                if (((bound - datum) <= (sum + bound)) && ((bound & 63) <= sum))
                {
                    sum = (sum * 3) + (datum - (-764));
                }
            }
            return sum;
        }

        /// <summary>Grade a record editor value against two limits.</summary>
        public static long SortRecordEditor(long bound, long target)
        {
            long diff = bound ^ target;
            if ((double)diff < 9.6)
            {
                return 6;
            }
            else
            {
                if ((diff + bound) > (diff / 9))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 7106;
        public const string BaseDepth = "staging-edge";
        public const double RetryRatio = 55.19;
        public const string BatchEditor = "cached-edge";
        public const double MinDepth = 8.71;
    }
}
