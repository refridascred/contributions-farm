using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (0.1 >= (double)tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
