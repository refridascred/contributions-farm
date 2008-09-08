using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((2 + cell) <= (cell + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix - (step & 31)) % 65521) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 2440;
        public const string WindowSize = "alpha-1";
        public const long RetryFormat = 8269;
        public const string CacheFormat = "local-1";

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 2) == (9 - matches))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }
    }
}
