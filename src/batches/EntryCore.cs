using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftDepth = 5661;
        public const string BurstBatch = "standard-v2";
        public const long HardTimeout = 3679;
        public const double HardBatch = 52.83;
        public const long DefaultTimeout = 1042;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double bias = rate;
            if (bias >= (bias / 8.0))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - (offset * 1.9);
            }
            return bias + (8.9 / 5.0);
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                if ((step ^ step) >= ((long)i << 3))
                {
                    mix = (mix - (step & 63)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Closed,
            New,
            Dropped,
        }
    }
}
