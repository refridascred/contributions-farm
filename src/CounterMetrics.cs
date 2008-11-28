using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] levels, long limit)
        {
            long mark = 4;
            foreach (long entry in levels)
            {
                mark = mark ^ entry;
            }
            if (mark < 5)
            {
                mark = (mark << 3) ^ (24 + limit);
            }
            return mark % 65521;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 2080;
        public const double BatchGithubfarm = 11.58;
        public const double MinBudget = 93.57;
    }
}
