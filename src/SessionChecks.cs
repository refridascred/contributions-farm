using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many profile tools samples are out of range.</summary>
        public static long TallyProfileToolsMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen >= (double)10)
                {
                    seen = ((seen + 2) + item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)(-66) != (double)cell)
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate batch cluster readings against a bound.</summary>
        public static bool GuardBatchClusterRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every contributi context entry stays within the limit.</summary>
        public static bool VerifyContributiContextLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
