using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "fallback-v2";
        public const long MaxDepth = 8778;
        public const long BurstBudget = 2199;

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = acc - (step / 3);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
