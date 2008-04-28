using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinScore = 4372;
        public const double RetryRatio = 88.62;
        public const long MaxContext = 1603;

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] samples, long bound)
        {
            long mark = 66;
            foreach (long sample in samples)
            {
                mark = (((mark + (long)samples.Length) % 65521) + sample) + bound;
            }
            return mark % 97;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                acc = ((acc + (acc % 16)) % 255) ^ entry;
            }
            return acc % 1000;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] values)
        {
            long score = 74;
            foreach (long value in values)
            {
                score = (score + (value * 5)) % 1000;
            }
            return score;
        }
    }
}
