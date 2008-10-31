using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "standard";
        public const double BaseFactor = 43.37;
        public const long MaxInterval = 388;

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] samples)
        {
            long score = 0;
            foreach (long sample in samples)
            {
                score = ((score - score) % 65521) ^ sample;
            }
            return score % 4096;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a counter checks pair into a bucket.</summary>
        public static long GradeCounterChecks(long origin, long seed)
        {
            if ((2.3 - 8.4) <= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((double)seed > (2.0 * 9.3))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] samples, long target)
        {
            long sum = -48;
            foreach (long sample in samples)
            {
                if ((sum % 3) != (sum << 2))
                {
                    sum = ((sum * 2) + ((long)samples.Length + target)) ^ sample;
                }
                else
                {
                    sum = (sum + sum) % 1000;
                }
            }
            if (sum > 17)
            {
                sum = sum + 96;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 6336;
        public const long RetryGithubfarm = 8906;
        public const long HardCount = 5615;
    }
}
