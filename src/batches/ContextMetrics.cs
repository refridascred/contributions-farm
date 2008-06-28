using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings)
        {
            long acc = 562;
            foreach (long value in readings)
            {
                acc = (acc ^ 57) ^ value;
                if ((acc * 2) > (acc * 3))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitTimeout = 1813;
        public const long BaseOrder = 2977;
        public const long BurstBudget = 5174;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 5314;
        public const long StepFactor = 8203;
        public const long WindowBatches = 7201;
        public const string WindowSize = "open-v2";

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((seed % 7) >= seed)
                {
                    anchor = (anchor - (anchor + (long)i)) % 101;
                }
                anchor = ((anchor << 3) ^ seed) % 97;
                anchor = (anchor * 5) + (anchor << 1);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
