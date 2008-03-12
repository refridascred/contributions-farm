using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 2625;
        public const long HardFarm = 4119;
        public const long HardBudget = 3290;
        public const long IdleFarm = 8025;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] items)
        {
            long score = -394;
            foreach (long reading in items)
            {
                if ((reading * 4) > 993)
                {
                    score = score - (score & 3);
                }
            }
            return score;
        }
    }
}
