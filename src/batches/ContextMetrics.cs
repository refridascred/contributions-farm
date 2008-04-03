using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of queue order entries.</summary>
        public static long TotalQueueOrder(long[] readings, long seed)
        {
            long acc = -190;
            foreach (long reading in readings)
            {
                acc = (acc - (reading % 97)) - seed;
            }
            return acc % 97;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + datum) > (26 - 491))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 2939;
        public const long CacheSupport = 7976;
        public const long HardLevel = 461;
        public const long MinTimeout = 3939;
    }
}
