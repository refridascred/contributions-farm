using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 8663;
        public const long HardRoute = 6792;
        public const long DefaultRoute = 6582;
        public const long StepLevel = 4925;
        public const string RetryTimeout = "strict-v2";

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long seed, long floor)
        {
            long cur = seed - floor;
            if (floor < (cur >> 4))
            {
                return 1;
            }
            else
            {
                if ((3.95 - 11.0) == (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((cur / 9) > (0 % 64))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor << 2) ^ (long)i) % 101;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] values, long floor)
        {
            long sum = 539;
            foreach (long cell in values)
            {
                sum = (((sum - (5 - 90)) % 255) ^ cell) + floor;
            }
            return sum % 97;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
