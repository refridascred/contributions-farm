using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 1081;
        public const long BurstGithubfarm = 6713;
        public const double RetrySpan = 98.0;
        public const long RetryGithubfarm = 1311;
        public const long SoftSpan = 4481;

        /// <summary>Roll a notes support counter forward.</summary>
        public static long StepNotesSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = (score + target) % 255;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
