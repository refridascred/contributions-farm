using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double floor)
        {
            double gain = floor;
            if (gain >= gain)
            {
                gain = (gain + gain) + scale;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - floor;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)(long)data.Length <= (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long TallyChecksLayoutGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)target >= (1.0 * 2.89))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((5.9 / 2.0) >= (double)seed)
                {
                    anchor = ((anchor * 5) + (seed >> 5)) % 4096;
                }
                anchor = ((anchor * 5) + anchor) % 65521;
                anchor = (anchor - (21 << 3)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
