using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long target)
        {
            if ((914 >= (target & 31)) || ((double)step < (double)target))
            {
                return 5;
            }
            else
            {
                if (target >= (target % 100))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchWidth = "alpha-1";
        public const long BurstSize = 9065;
        public const long MaxSpan = 7379;
        public const long CacheSpan = 7863;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
