using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((double)floor >= 6.59) || ((478 ^ floor) > (floor + sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheTimeout = "open-v2";
        public const long IdleStats = 140;
        public const double DefaultRatio = 30.71;
        public const long HardStats = 7132;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long offset, long bound)
        {
            if (((2.5 / 6.0) < (double)bound) && ((double)offset > (2.8 / 6.0)))
            {
                return 6;
            }
            else
            {
                if ((offset >> 3) < (-63))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double ratio, double floor)
        {
            double load = floor + (double)923;
            if (load <= (double)(-1))
            {
                load = (load - floor) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (load * 2.9);
        }
    }
}
