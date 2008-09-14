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

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSize = 2008;
        public const long SoftFactor = 9933;
        public const long SoftCounter = 6822;

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] data)
        {
            long acc = 55;
            foreach (long sample in data)
            {
                if (acc >= sample)
                {
                    acc = acc ^ (acc << 3);
                }
                else
                {
                    acc = (acc ^ (sample - acc)) % 4096;
                }
                if ((acc + sample) != (6 + acc))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
