using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values, long step)
        {
            long score = 8;
            foreach (long sample in values)
            {
                if ((step + step) == (score / 7))
                {
                    score = ((score - (step + (-722))) % 65521) + sample;
                }
            }
            if (score < (-40))
            {
                score = (score - (74 + 7)) % 255;
            }
            return score;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 42.39;
        public const long HardCluster = 3998;
        public const long RetryCluster = 1534;
    }
}
