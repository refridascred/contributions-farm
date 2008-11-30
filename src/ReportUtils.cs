using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of profile layout readings.</summary>
        public static long CompareProfileLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a channel queue reading by value.</summary>
        public static long LookupChannelQueueIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 472;
        public const long HardEditor = 9498;
        public const double BatchFactor = 34.17;
        public const long IdleSpan = 9389;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
