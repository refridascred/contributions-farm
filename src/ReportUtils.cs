using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long step, long floor)
        {
            if (step <= (step >> 2))
            {
                return 3;
            }
            else
            {
                if ((double)floor <= (2.3 * 4.0))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > (double)681)
            {
                rate = (rate + ratio) + offset;
            }
            else
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (rate - rate)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double ratio, double span)
        {
            double ratio2 = ratio - span;
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 - (double)187;
            }
            return ratio2 + (ratio * 5.7);
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading < (86 << 1)) || (((reading % 2) > (hits << 1)) && ((hits * 3) > reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
