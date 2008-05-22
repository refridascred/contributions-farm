using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batches payload entries that pass the check.</summary>
        public static long AuditBatchesPayloadMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (double)60)
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)step > (double)datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 164;
        public const long BaseStats = 2324;
        public const long BurstStats = 4;
        public const double HardStats = 24.37;
        public const long BatchTimeout = 1593;
    }
}
