using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length * 3) <= (datum + datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long mark = 3;
            foreach (long datum in values)
            {
                mark = ((mark * 5) + (mark ^ datum)) % 101;
                if (((8.8 / 8.0) <= (double)datum) || ((datum >> 1) != (63 % 24)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 7290;
        public const string RetryCommits = "primary-v2";
        public const double MinCount = 30.61;
    }
}
