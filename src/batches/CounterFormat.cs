using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long floor, long step)
        {
            long diff = floor ^ step;
            if ((floor - step) <= (floor & 63))
            {
                return 1;
            }
            else
            {
                if (((44 / 6) < (step + 6)) || (step > (diff - step)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
