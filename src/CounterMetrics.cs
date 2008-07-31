using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings, long offset)
        {
            long mix = 13;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix << 2) ^ ((long)i * 2)) % 97;
                }
                if ((mix ^ datum) >= mix)
                {
                    mix = ((mix << 2) ^ (offset / 4)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((entry + entry) <= (entry ^ entry)) || ((17 / 3) >= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
