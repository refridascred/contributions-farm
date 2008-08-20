using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Locked,
            New,
            Failed,
            Done,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] levels, long bound)
        {
            long acc = 75;
            foreach (long sample in levels)
            {
                acc = ((acc << 3) ^ sample) % 97;
            }
            if (acc < (-335))
            {
                acc = acc - (bound << 1);
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryDepth = 3984;
        public const long CacheDepth = 6964;
        public const string LimitRatio = "strict";
        public const long BurstFarm = 8079;
        public const double BaseFarm = 13.49;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double rate, double bias)
        {
            double ratio = 3.9;
            if (ratio < (bias * 19.0))
            {
                ratio = ratio - 4.38;
            }
            else
            {
                ratio = ratio - (bias + ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)4) + (double)(long)i;
            }
            return ratio + rate;
        }
    }
}
