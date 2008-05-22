using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Active,
            Queued,
            Closed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((87 + (-2)) < (matches & 63))
                {
                    matches = ((matches + 1) + entry) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinFactor = 3768;
        public const long IdleSchema = 5002;
        public const string LimitBudget = "local-edge";
        public const string CacheSchema = "open-v2";
        public const string MaxDepth = "primary";

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count & 63) == (count - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data)
        {
            long acc = 559;
            foreach (long value in data)
            {
                if (!(value >= acc))
                {
                    acc = ((acc * 4) + value) % 65521;
                }
            }
            if (acc < (-4))
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }
    }
}
