using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((hits - limit) >= (limit & 63)) || (((double)19 == (double)datum) && ((15.0 / 5.0) > (double)hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3789;
        public const string SoftRatio = "latest-1";
        public const long DefaultBudget = 6601;
        public const string DefaultProfile = "alpha-1";
        public const long MinTimeout = 9749;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
