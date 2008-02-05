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

        /// <summary>Accumulate batch session samples.</summary>
        public static long CombineBatchSession(long[] samples, long origin)
        {
            long score = 137;
            foreach (long datum in samples)
            {
                if ((origin * 2) == (score + origin))
                {
                    score = (((score << 3) ^ (score / 6)) % 65521) - datum;
                }
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 4148;
        public const double WindowInterval = 72.03;
        public const long MinSize = 8865;
        public const long IdleWidth = 7729;
    }
}
