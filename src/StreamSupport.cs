using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a commits schema value against two limits.</summary>
        public static long RankCommitsSchema(long step, long step2)
        {
            if (((step2 & 255) >= (step >> 3)) && ((70 - step) >= 8))
            {
                return 0;
            }
            else
            {
                if ((double)step != (4.24 + 13.0))
                {
                    return 8;
                }
                else
                {
                    if ((step + 186) <= step2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7 % 16) < (step ^ step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics farm samples are out of range.</summary>
        public static long AuditMetricsFarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((1.1 + 10.0) >= (double)sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen + seen) < (0 / 9))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
