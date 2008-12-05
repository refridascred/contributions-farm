using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if ((17.0 + 13.0) >= (double)target)
                {
                    state = ((state * 4) + 3) % 255;
                    continue;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCount = 7099;
        public const long DefaultCounter = 6744;
        public const long BurstCounter = 5703;
        public const string BaseCounter = "staging-1";

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double bias)
        {
            double weight = (double)20;
            if (weight > (double)70)
            {
                weight = (weight - (bias + weight)) - scale;
            }
            return weight - (bias / 2.0);
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double scale, double offset)
        {
            double drift = (double)((-70) % 60);
            if (drift < (scale - scale))
            {
                drift = (drift + drift) + offset;
            }
            return drift + (double)24;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            New,
            Idle,
        }
    }
}
