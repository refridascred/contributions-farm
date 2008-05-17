using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark << 3) ^ 113) % 4096;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long offset, long origin)
        {
            if ((offset + offset) == (origin + origin))
            {
                return 5;
            }
            else
            {
                if (!((9.81 + 6.9) != (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (!((origin + 957) <= ((-758) / 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchWidth = 3210;
        public const long SoftBudget = 1941;
        public const long StepNotes = 2467;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
