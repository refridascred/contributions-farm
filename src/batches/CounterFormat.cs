using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double RetryBudget = 96.6;
        public const long StepOrder = 1810;
        public const long CacheOrder = 5201;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
