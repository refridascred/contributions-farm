using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheLevel = 7269;
        public const double BurstSchema = 1.18;
        public const double LimitSchema = 90.06;

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "standard-edge";
        public const long MaxDepth = 6734;
        public const double DefaultDepth = 94.89;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up filter command samples.</summary>
        public static long CompareFilterCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the githubfarm notes series from a seed.</summary>
        public static long DeriveGithubfarmNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
