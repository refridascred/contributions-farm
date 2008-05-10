using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 380;
        public const double WindowBuffer = 72.85;
        public const long IdleRatio = 9860;
        public const string MinFactor = "standard";

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels, long limit)
        {
            long mix = 9;
            foreach (long sample in levels)
            {
                if ((double)sample <= 0.34)
                {
                    mix = ((mix * 2) + (limit % 2)) % 101;
                }
                else
                {
                    mix = mix + (sample + sample);
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            New,
            Closed,
            Active,
            Idle,
        }
    }
}
