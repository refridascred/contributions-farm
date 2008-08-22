using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 730;
        public const long StepStats = 4161;
        public const long DefaultLevel = 5553;
        public const long BatchStats = 355;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseDepth = 2639;
        public const long RetryBatches = 3827;
        public const string StepBatches = "legacy";
        public const double MaxRatio = 87.5;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                bool stale = !(floor > ((long)i - sum));
                if (stale || (((-846) << 2) < (sum + floor)))
                {
                    sum = sum - (sum << 2);
                }
                else
                {
                    sum = (sum << 2) ^ (27 % 12);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum ^ (sum + 60)) - (long)i2;
                    sum = ((sum << 3) ^ (sum >> 5)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            Active,
            Idle,
            New,
            Stale,
        }
    }
}
