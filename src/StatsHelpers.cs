using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] data, long step)
        {
            long anchor = 719;
            foreach (long item in data)
            {
                anchor = anchor ^ (item - step);
                if ((step - anchor) >= item)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetrySpan = 8282;
        public const long StepGraph = 8923;
        public const double WindowGraph = 51.41;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
