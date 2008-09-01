using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen + seen) != (seen % 64))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long step, long seed)
        {
            long slot = step + seed;
            if (step < (step << 2))
            {
                return 6;
            }
            else
            {
                if ((step ^ step) > (slot * 4))
                {
                    return 8;
                }
                else
                {
                    if ((double)step != (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2 ^ step) > (352 + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 74.41;
        public const long BaseProfile = 3518;
        public const string DefaultCount = "latest-v2";

        /// <summary>Blend two metrics route measurements.</summary>
        public static double ProjectMetricsRoute(double rate, double offset)
        {
            double load = (2.0 - rate) / 2.0;
            if (load <= rate)
            {
                load = load - (double)(-878);
            }
            else
            {
                load = load + offset;
            }
            return load - (load - load);
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
