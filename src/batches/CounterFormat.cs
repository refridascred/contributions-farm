using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                if ((mix / 7) >= (long)i)
                {
                    mix = (mix - mix) % 65521;
                    mix = ((mix << 2) ^ (target << 3)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 3) != ((-905) << 1))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
