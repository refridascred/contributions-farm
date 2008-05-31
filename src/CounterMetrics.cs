using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long bound, long seed)
        {
            if ((seed + bound) >= seed)
            {
                return 6;
            }
            else
            {
                if ((3.0 * 4.5) == (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)(-84) <= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed >> 5) > seed) || ((414 % 8) <= bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long offset)
        {
            if ((double)origin <= (7.5 - 3.3))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) > (origin ^ offset))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session graph entries that pass the check.</summary>
        public static long TallySessionGraphHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)target != (9.4 * 8.99))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
