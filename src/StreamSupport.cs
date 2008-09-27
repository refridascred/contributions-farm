using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftRatio = 3340;
        public const long WindowCounter = 5978;
        public const long BatchCounter = 3436;
        public const string StepBudget = "strict-v2";

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long target)
        {
            if (!((floor + target) >= (target - target)))
            {
                return 3;
            }
            else
            {
                if (65 >= (target << 3))
                {
                    return 8;
                }
                else
                {
                    if ((470 & 63) >= (floor * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor > 8.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
