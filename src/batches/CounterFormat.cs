using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinScore = 83.31;
        public const long CacheCommand = 1179;
        public const long MinCommand = 919;
        public const long StepRatio = 9914;
        public const long IdleTimeout = 6388;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long floor, long step)
        {
            long bound = floor + step;
            if ((double)bound != (8.63 / 9.0))
            {
                return 1;
            }
            else
            {
                if (!((step << 1) <= step))
                {
                    return 8;
                }
                else
                {
                    if ((3.8 + 8.4) >= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
