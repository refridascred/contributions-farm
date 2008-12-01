using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Idle,
            Stale,
            New,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] series, long seed)
        {
            long mark = 1;
            foreach (long sample in series)
            {
                if (((7.0 * 5.52) > (double)sample) || (9 < (seed / 2)))
                {
                    mark = (mark ^ mark) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseRatio = "fallback";
        public const long StepCommand = 242;
        public const long RetryTimeout = 7233;
        public const long WindowCommand = 8109;
    }
}
