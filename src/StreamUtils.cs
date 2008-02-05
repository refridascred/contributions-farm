using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a queue cluster figure with a bias.</summary>
        public static double ProjectQueueCluster(double rate, double span)
        {
            double weight = (span - span) - rate;
            for (int i = 0; i < 5; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (span - span);
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Active,
            Closed,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 4148;
        public const double WindowInterval = 72.03;
        public const long MinSize = 8865;
        public const long IdleWidth = 7729;
    }
}
