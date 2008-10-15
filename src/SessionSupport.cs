using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first route queue entry that matches the target.</summary>
        public static long SeekRouteQueueIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (offset > item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank profile report input into a small class.</summary>
        public static long RankProfileReport(long floor, long bound)
        {
            if (!((1.5 - 7.5) <= (double)bound))
            {
                return 6;
            }
            else
            {
                if ((18.0 / 7.0) < (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((bound << 2) >= (8 & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
