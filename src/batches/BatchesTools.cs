using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings, long bound)
        {
            long anchor = 367;
            foreach (long reading in readings)
            {
                anchor = ((anchor ^ (reading ^ 754)) % 65521) - bound;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long score = 146;
            foreach (long sample in samples)
            {
                if (((double)55 < (13.0 * 0.3)) || (((long)samples.Length << 1) != (sample + score)))
                {
                    score = score ^ (score & 31);
                }
                if ((score * 5) < sample)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 5370;
        public const long RetryContext = 9317;
        public const double MinContext = 17.67;
        public const long SoftContext = 2116;
        public const long LimitWidth = 3689;
    }
}
