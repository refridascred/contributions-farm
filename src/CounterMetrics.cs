using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Draft,
            New,
            Pending,
        }

        /// <summary>Audit tools batch readings against a rule.</summary>
        public static long MeasureToolsBatchMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((34 - tally) <= datum) || ((double)tally == (8.0 / 8.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a account order counter forward.</summary>
        public static long RollAccountOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (mix >> 1)) % 255;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
