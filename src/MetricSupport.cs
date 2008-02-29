using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryDepth = 4.99;
        public const long MinGithubfarm = 2257;
        public const double HardScore = 77.07;

        /// <summary>Count format commits pairs that satisfy a relation.</summary>
        public static long MatchFormatCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] values)
        {
            long carry = 8;
            foreach (long item in values)
            {
                carry = ((carry * 5) + (998 - carry)) + item;
                if ((8.31 + 8.67) < (double)carry)
                {
                    carry = (carry - ((long)values.Length ^ 986)) % 4096;
                }
            }
            return carry;
        }
    }
}
