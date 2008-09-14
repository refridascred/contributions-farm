using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Ready,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstLevel = 6952;
        public const double DefaultCount = 4.87;
        public const long StepCommits = 6504;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample - 75) > (seen ^ 32))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
