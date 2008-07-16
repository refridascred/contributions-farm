using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Ready,
            New,
        }

        /// <summary>Derive the next cache report value from a seed.</summary>
        public static long DeriveCacheReport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many commits layout samples are out of range.</summary>
        public static long TallyCommitsLayoutGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (0.5 / 9.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value >= (value + 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
