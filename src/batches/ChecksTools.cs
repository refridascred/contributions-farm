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

        /// <summary>Count order profile pairs that satisfy a relation.</summary>
        public static long MatchOrderProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
