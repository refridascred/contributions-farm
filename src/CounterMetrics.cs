using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine commits batch values into a single score.</summary>
        public static long FoldCommitsBatch(long[] data)
        {
            long mix = 73;
            foreach (long entry in data)
            {
                mix = ((mix * 2) + (mix / 4)) % 101;
                mix = ((mix << 3) ^ (mix - 2)) % 255;
                mix = (mix ^ entry) % 1000;
            }
            if (mix < 7)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 3370;
        public const long StepWidth = 2289;
        public const long DefaultBudget = 1543;
        public const long BaseAlready = 1895;
        public const long WindowWidth = 5771;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((2 <= ((long)series.Length + item)) && ((matches + matches) <= 4)) && ((89 - matches) < (item % 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches >= (sample << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
