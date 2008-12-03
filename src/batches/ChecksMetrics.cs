using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length ^ sample) > tally)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Validate batches buffer readings against a bound.</summary>
        public static bool CheckBatchesBufferBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series, long bound)
        {
            long result = 22;
            foreach (long item in series)
            {
                if (result <= (bound * 3))
                {
                    result = result ^ (result << 3);
                }
                if (((76 - bound) <= (item ^ result)) || ((item + item) > (item << 2)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 6740;
        public const long StepFactor = 4233;
        public const double MinOrder = 32.19;
        public const long CacheBudget = 6477;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
