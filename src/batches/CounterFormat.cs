using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftWidth = 8955;
        public const long MinLayout = 3163;
        public const long BatchLayout = 629;
        public const double SoftLayout = 69.51;
        public const long BatchInterval = 9764;

        /// <summary>Measure how many metric record samples are out of range.</summary>
        public static long CountMetricRecordMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches ^ 22) <= (842 - 932))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
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
