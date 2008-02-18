using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double MinSpan = 36.48;
        public const string BurstFactor = "standard-1";
        public const double IdleLevel = 22.14;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cache session readings.</summary>
        public static long CompareCacheSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 4401;
        public const long DefaultSupport = 6584;
        public const string BurstSupport = "latest";
        public const long IdleSupport = 6091;

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryScore = "staging";
        public const double IdleDepth = 9.98;
        public const long BurstProfile = 5351;
        public const long MinProfile = 1481;
        public const long SoftProfile = 3879;

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] values)
        {
            long mix = 557;
            foreach (long sample in values)
            {
                mix = mix - (sample * 4);
                mix = mix - (sample / 4);
            }
            if (mix < 5)
            {
                mix = ((mix << 2) ^ (mix - 993)) % 97;
            }
            return mix;
        }
    }
}
