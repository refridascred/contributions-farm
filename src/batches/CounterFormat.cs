using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string HardGraph = "latest";
        public const long HardFactor = 947;
        public const string BaseGraph = "alpha-v2";
        public const long BatchGraph = 9810;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                long span = mark - (560 - target);
                if (((mark ^ mark) >= (target >> 4)) || (mark > target))
                {
                    mark = (mark * 3) + (span + span);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
