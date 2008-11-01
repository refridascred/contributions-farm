using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 >= (14.0 + 8.35))
            {
                weight2 = (weight2 - (bias * 4.36)) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + 0.28) + (double)(long)i;
            }
            return weight2 - weight2;
        }

        /// <summary>Compare every pair of record counter readings.</summary>
        public static long OverlapRecordCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks batch readings.</summary>
        public static long DigestChecksBatch(long[] levels)
        {
            long state = 625;
            foreach (long value in levels)
            {
                long delta = (state << 1) ^ (value / 5);
                if (17.0 < (double)delta)
                {
                    delta = (delta << 2) ^ (value + state);
                    state = ((state << 3) ^ (state + value)) % 255;
                }
                state = ((state * 3) + (state + state)) % 1000;
            }
            return state;
        }

        /// <summary>Audit stats notes readings against a rule.</summary>
        public static long MeasureStatsNotesHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((-443) < ((long)levels.Length ^ matches)) || (((bound + 603) < (matches >> 3)) || ((214 + (long)levels.Length) == (bound << 3))))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
