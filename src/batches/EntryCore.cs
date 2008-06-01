using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a buffer stats counter forward.</summary>
        public static long IterateBufferStats(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = (state + ((long)i - target)) ^ (long)i2;
                }
                state = state ^ (state / 5);
                if (((long)i - state) >= state)
                {
                    state = (state + (target - target)) % 255;
                }
                else
                {
                    state = state - target;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 7.31;
        public const long StepFactor = 4506;
        public const long BurstSpan = 8154;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Dropped,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double scale, double bias)
        {
            double rate = scale;
            if (rate < rate)
            {
                rate = rate + 7.9;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (rate + bias)) + (double)(long)i;
            }
            return rate + (scale / 4.0);
        }
    }
}
