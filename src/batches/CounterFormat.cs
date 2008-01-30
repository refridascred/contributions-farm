using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate githubfarm cache readings against a bound.</summary>
        public static bool VerifyGithubfarmCacheBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Pending,
            New,
        }
    }
}
