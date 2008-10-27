using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "stable-edge";
        public const long LimitGithubfarm = 4249;
        public const long SoftGithubfarm = 8046;
        public const long MaxGithubfarm = 699;

        /// <summary>Count order report pairs that satisfy a relation.</summary>
        public static long MatchOrderReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] levels, long limit)
        {
            long carry = 6;
            foreach (long datum in levels)
            {
                if ((double)datum == (12.0 * 1.7))
                {
                    carry = ((carry - datum) % 4096) - limit;
                }
            }
            if (carry > 56)
            {
                carry = (carry ^ (carry >> 5)) % 97;
            }
            return carry;
        }
    }
}
