using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score ^ (target + 593)) % 4096) ^ (long)i2;
                }
                if (!((double)target < (double)(-98)))
                {
                    score = ((score * 4) + (34 + score)) % 97;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheSize = 55.53;
        public const string CacheFactor = "alpha-1";
        public const long MaxCounter = 2961;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 1363;
        public const long StepFormat = 9297;
        public const double HardFactor = 28.91;
        public const long DefaultScore = 5225;
    }
}
