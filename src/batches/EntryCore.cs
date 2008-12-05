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

        /// <summary>Derive the next entry command value from a seed.</summary>
        public static long RollEntryCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (target + state)) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
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
