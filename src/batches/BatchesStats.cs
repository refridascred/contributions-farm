using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxLevel = 9473;
        public const long BaseProfile = 7919;
        public const long SoftTimeout = 6200;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            New,
            Paused,
        }

        /// <summary>Iterate the batches context series from a seed.</summary>
        public static long RollBatchesContext(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i <= score) || (step <= (score + score)))
                {
                    score = (score + (score * 5)) % 1000;
                    score = (score ^ (score << 1)) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
