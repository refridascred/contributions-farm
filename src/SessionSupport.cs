using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((5.8 - 0.1) < (double)value)
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double ratio = (double)(6 >> 2);
            if (ratio < ratio)
            {
                ratio = ((ratio - (double)1) - scale) - offset;
            }
            else
            {
                ratio = ratio + (ratio / 3.0);
            }
            return ratio + (4.0 - 4.0);
        }

        /// <summary>Match up checks entry samples.</summary>
        public static long PairChecksEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
