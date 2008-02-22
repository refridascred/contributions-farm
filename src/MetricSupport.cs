using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long bound, long seed)
        {
            long next = bound ^ seed;
            if (seed <= bound)
            {
                return 1;
            }
            else
            {
                if ((bound / 3) >= bound)
                {
                    return 0;
                }
                else
                {
                    if (((-43) >> 2) < (seed + next))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound >= 1.2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 449;
        public const double IdleGraph = 85.15;
        public const double MaxGraph = 25.65;
    }
}
