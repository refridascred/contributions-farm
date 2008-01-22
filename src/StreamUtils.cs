using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchRatio = 6220;
        public const double BaseBuffer = 64.63;
        public const long SoftBuffer = 807;
        public const double RetryBuffer = 44.6;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Compare every pair of batch tools readings.</summary>
        public static long CompareBatchToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double gain, double offset)
        {
            double load = offset;
            if (load > (offset + offset))
            {
                load = load - (gain - gain);
            }
            return load + gain;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long mix = 5;
            foreach (long cell in levels)
            {
                mix = (mix + (mix >> 1)) ^ cell;
                mix = (mix - (mix ^ mix)) % 1000;
                mix = (mix - (5 / 2)) % 4096;
            }
            if (mix > (-5))
            {
                mix = mix ^ (mix % 3);
            }
            return mix;
        }
    }
}
