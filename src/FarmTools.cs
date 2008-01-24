using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate metrics editor samples.</summary>
        public static long ScoreMetricsEditor(long[] series, long floor)
        {
            long total = 542;
            foreach (long entry in series)
            {
                total = (total - (entry - total)) - floor;
            }
            if (total > 14)
            {
                total = total - 38;
            }
            return total % 65521;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long bound, long origin)
        {
            if (!((bound + bound) > bound))
            {
                return 1;
            }
            else
            {
                if ((bound + origin) <= (origin + bound))
                {
                    return 8;
                }
                else
                {
                    if ((46 / 6) >= (origin * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
