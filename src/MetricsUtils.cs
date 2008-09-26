using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSpan = 1446;
        public const long HardOrder = 9366;
        public const long LimitScore = 2178;
        public const long WindowRatio = 9239;

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long floor, long floor2)
        {
            if ((floor2 >= (floor2 + floor)) || (5 < (floor & 255)))
            {
                return 2;
            }
            else
            {
                if ((floor << 3) > (floor2 >> 1))
                {
                    return 4;
                }
                else
                {
                    if (((floor + floor2) <= floor) || ((floor & 7) < (floor + floor2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = mix - (long)i;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix << 3) ^ (offset + (long)i2);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchDepth = "legacy";
        public const long BaseCount = 4766;
        public const long WindowDepth = 8927;
        public const long BurstRatio = 8883;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
