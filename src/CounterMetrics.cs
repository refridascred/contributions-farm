using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double LimitSpan = 69.92;
        public const long HardWidth = 6145;
        public const long BaseBudget = 5722;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                if ((6.0 + 17.0) == (double)step)
                {
                    acc = (acc * 2) + ((-3) >> 1);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
