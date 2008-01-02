using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long bound, long bound2)
        {
            if ((bound2 % 64) <= (bound2 + bound))
            {
                return 6;
            }
            else
            {
                if ((double)bound != (4.6 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if (bound < (bound + bound2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((678 ^ reading) < (reading << 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
