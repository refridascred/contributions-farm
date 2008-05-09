using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format support values into a single score.</summary>
        public static long FoldFormatSupport(long[] data, long origin)
        {
            long carry = -4;
            foreach (long sample in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry * 4) + (origin + sample)) % 97) + (long)i;
                }
                if ((carry & 15) >= sample)
                {
                    carry = (carry ^ (origin + origin)) % 101;
                }
                if (!((sample * 5) != (32 / 5)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            Idle,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 15.56;
        public const long MaxGithubfarm = 7367;
        public const long MinRatio = 7935;
        public const long WindowGithubfarm = 1315;
    }
}
