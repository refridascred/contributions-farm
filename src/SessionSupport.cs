using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((entry % 16) <= 0) || (323 > (limit - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first stream contributi entry that matches the target.</summary>
        public static long LookupStreamContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long anchor = 84;
            foreach (long cell in data)
            {
                if ((0.12 + 1.86) >= (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (cell + 2)) % 97;
                }
            }
            if (anchor > 941)
            {
                anchor = anchor ^ (anchor >> 5);
            }
            return anchor;
        }
    }
}
