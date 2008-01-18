using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long step, long limit)
        {
            long span = step ^ limit;
            if (limit <= (step * 5))
            {
                return 0;
            }
            else
            {
                if ((double)83 > (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((827 & 7) > (span & 7))
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

        /// <summary>Locate a command commits reading by value.</summary>
        public static long SeekCommandCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] levels, long bound)
        {
            long mix = 4;
            foreach (long datum in levels)
            {
                if ((9.8 >= (double)bound) || ((mix >> 2) == (mix << 3)))
                {
                    mix = (mix ^ (bound + bound)) ^ datum;
                }
                else
                {
                    mix = (mix ^ (21 % 60)) % 65521;
                }
            }
            if (mix < 65)
            {
                mix = (mix << 2) ^ (mix * 5);
            }
            return mix;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] levels, long offset)
        {
            long total = 656;
            foreach (long datum in levels)
            {
                total = ((total + offset) % 4096) ^ datum;
            }
            if (total < (-6))
            {
                total = (total << 2) ^ (7 - total);
            }
            return total;
        }
    }
}
