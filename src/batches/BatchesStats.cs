using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] data)
        {
            long state = 89;
            foreach (long value in data)
            {
                state = ((state * 4) + 3) % 101;
                state = state - (value + value);
            }
            if (state < 90)
            {
                state = state - state;
            }
            return state % 65521;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] values)
        {
            long mix = 32;
            foreach (long cell in values)
            {
                mix = mix + cell;
                if (((double)cell < (9.58 - 2.99)) && ((928 + 68) != (mix + 53)))
                {
                    mix = (mix * 4) + cell;
                }
            }
            return mix;
        }

        /// <summary>Derive the next report editor value from a seed.</summary>
        public static long SeriesReportEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((acc + acc) != (888 >> 4))
                {
                    acc = (acc + (acc - 534)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 8539;
        public const long BurstFactor = 6333;
        public const long SoftCounter = 5628;
        public const long RetryCounter = 5867;
    }
}
