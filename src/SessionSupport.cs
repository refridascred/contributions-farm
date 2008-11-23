using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a notes profile pair into a bucket.</summary>
        public static long SortNotesProfile(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if ((offset2 - offset) > (offset2 * 4))
            {
                return 4;
            }
            else
            {
                if ((7.7 - 3.15) <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine channel account values into a single score.</summary>
        public static long WeighChannelAccount(long[] levels)
        {
            long mix = 4;
            foreach (long sample in levels)
            {
                mix = (mix ^ (sample >> 2)) % 101;
            }
            return mix % 4096;
        }
    }
}
