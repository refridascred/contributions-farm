using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum / 4) < (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "legacy-edge";
        public const long WindowAccount = 1096;
        public const double IdleAccount = 50.21;
        public const long SoftAccount = 5475;
        public const long HardScore = 3782;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 1226;
        public const long BaseOrder = 8717;
        public const long IdleOrder = 6845;
    }
}
