using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultSize = 2182;
        public const long HardFactor = 6265;
        public const long RetryStats = 4213;
        public const long MinCount = 8756;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Synced,
            Closed,
            Done,
            Ready,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Retry,
            Queued,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = (score << 2) ^ 56;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long CountWindowNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((8.2 - 3.7) != (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
