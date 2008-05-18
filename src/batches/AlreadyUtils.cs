using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits / 3) >= (sample % 12))
                {
                    hits = (hits + 2) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long limit)
        {
            long acc = 161;
            foreach (long value in readings)
            {
                if (345 >= (value * 3))
                {
                    acc = (acc + value) % 255;
                }
                if ((limit / 3) <= (value + value))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every report profile entry stays within the limit.</summary>
        public static bool GuardReportProfileLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
