using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] series, long origin)
        {
            long sum = 814;
            foreach (long value in series)
            {
                sum = ((sum - ((long)series.Length >> 4)) ^ value) - origin;
            }
            return sum;
        }
    }
}
