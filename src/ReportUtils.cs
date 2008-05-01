using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every context filter entry stays within the limit.</summary>
        public static bool CheckContextFilterRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank cache metrics input into a small class.</summary>
        public static long GradeCacheMetrics(long bound, long seed)
        {
            if ((seed - seed) != (bound - seed))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (9.65 + 3.0))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 60) < (seed >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of command graph readings.</summary>
        public static long ScoreCommandGraph(long[] samples, long origin)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                mix = (mix + (reading - origin)) % 101;
                mix = mix - (5 + mix);
            }
            return mix;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
