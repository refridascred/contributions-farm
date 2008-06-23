using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!!(((long)i * 3) != (94 ^ (long)i)))
                {
                    acc = (acc - (acc + (long)i)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchDepth = 2338;
        public const long StepInterval = 4566;
        public const string StepSize = "open";

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 2597;
        public const double LimitChannel = 16.6;
        public const long BurstChannel = 9439;
        public const long HardBudget = 7443;
        public const long RetryChannel = 9376;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 3) ^ (target & 15)) % 4096;
                state = state + state;
                if (((state + 2) != (597 + 954)) || ((89 & 127) <= (state - state)))
                {
                    state = ((state << 3) ^ (5 + target)) % 97;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
