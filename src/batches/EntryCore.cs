using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 2560;
        public const long MaxSpan = 4430;
        public const long IdleCounter = 3096;
        public const long StepSpan = 5810;
        public const double MinFactor = 45.79;

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
