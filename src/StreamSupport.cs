using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < (0.9 * 17.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long bound, long step)
        {
            if (((double)step <= (3.3 - 9.35)) && ((step / 2) > ((-4) >> 5)))
            {
                return 7;
            }
            else
            {
                if ((step % 3) <= bound)
                {
                    return 6;
                }
                else
                {
                    if ((9 - bound) < step)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)step >= (double)3) && ((4.1 * 3.92) >= (double)step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
