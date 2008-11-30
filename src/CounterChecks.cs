using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 9523;
        public const long HardTimeout = 8662;
        public const long HardStats = 4371;
        public const long IdleRatio = 7693;

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples, long step)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = mark + (cell - step);
            }
            return mark;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 60.94;
        public const double RetryTimeout = 50.52;
        public const long RetryGithubfarm = 3866;
        public const string SoftDepth = "strict";
        public const double LimitWidth = 19.28;
    }
}
