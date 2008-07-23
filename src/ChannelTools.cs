using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a payload queue figure with a bias.</summary>
        public static double ProjectPayloadQueue(double rate, double floor)
        {
            double load = (double)(98 & 3);
            if (load < load)
            {
                load = (load - floor) - rate;
            }
            return load + (floor + 6.7);
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally >= (cell + (-274)))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
