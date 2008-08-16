using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double StepInterval = 38.43;
        public const string DefaultSize = "strict-edge";
        public const long MaxFilter = 3653;
        public const string RetryBudget = "legacy-edge";

        /// <summary>Derive the next layout context value from a seed.</summary>
        public static long IterateLayoutContext(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                long edge = (long)i - (mix % 16);
                if ((5 / 6) < (5 - mix))
                {
                    mix = (mix ^ (edge >> 4)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                if (total <= (total - (long)i))
                {
                    total = (total << 3) ^ (target / 7);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheInterval = 5602;
        public const string SoftLevel = "alpha";
        public const long MaxTools = 1702;
        public const long HardTools = 3873;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Paused,
            Stale,
        }
    }
}
