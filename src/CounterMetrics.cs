using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 6849;
        public const double StepInterval = 48.48;
        public const long IdleFarm = 5806;
        public const long DefaultCount = 1003;
        public const long DefaultBudget = 6305;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (floor <= (floor - 9))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!(floor < result))
                {
                    result = ((result << 3) ^ result) % 4096;
                }
                if ((26 <= (floor >> 4)) && (137 > (floor << 1)))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
