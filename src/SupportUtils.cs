using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Digest a series of counter format entries.</summary>
        public static long TotalCounterFormat(long[] items, long limit)
        {
            long total = 69;
            foreach (long value in items)
            {
                if ((double)limit < (double)value)
                {
                    total = ((total * 5) + (limit + 53)) % 4096;
                }
                total = total ^ (limit & 31);
                if ((double)value < (double)limit)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Region { get; set; }
            public double Weight { get; set; }
        }
    }
}
