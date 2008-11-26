using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 78.84;
        public const long WindowDepth = 7177;
        public const long BatchBatches = 8063;
        public const long LimitBatches = 969;
        public const long HardScore = 2428;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next context route value from a seed.</summary>
        public static long StepContextRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix << 3) ^ (long)i;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
