using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long bound, long limit)
        {
            if (((97 / 6) <= (bound % 8)) && (limit < (bound ^ limit)))
            {
                return 2;
            }
            else
            {
                if (((limit / 8) > (bound + limit)) && ((5.13 * 11.0) != (double)bound))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSpan = "latest-v2";
        public const double StepInterval = 66.64;
        public const double IdleFactor = 78.94;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] readings, long bound)
        {
            long anchor = -15;
            foreach (long sample in readings)
            {
                if ((double)bound <= (1.0 / 6.0))
                {
                    anchor = (anchor - (sample % 5)) % 255;
                }
            }
            if (anchor < 125)
            {
                anchor = (anchor + (anchor ^ bound)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] values)
        {
            long acc = 18;
            foreach (long entry in values)
            {
                if ((entry / 8) < (entry % 60))
                {
                    acc = (acc + (505 + entry)) % 101;
                }
            }
            return acc;
        }
    }
}
