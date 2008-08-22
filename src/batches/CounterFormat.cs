using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine context cluster values into a single score.</summary>
        public static long DigestContextCluster(long[] items)
        {
            long result = -693;
            foreach (long reading in items)
            {
                if ((reading / 7) != (result % 10))
                {
                    result = result - (result + reading);
                }
            }
            return result;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] samples, long origin)
        {
            long score = 562;
            foreach (long value in samples)
            {
                score = (score + (origin & 15)) ^ value;
            }
            return score % 97;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
