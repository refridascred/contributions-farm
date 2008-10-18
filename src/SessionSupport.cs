using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((matches + matches) <= (matches >> 4)) || (floor <= matches))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long seed, long seed2)
        {
            long lane = seed + seed2;
            if (seed > (seed2 * 4))
            {
                return 8;
            }
            else
            {
                if (seed <= (seed2 << 1))
                {
                    return 3;
                }
                else
                {
                    if (lane >= (lane + 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
