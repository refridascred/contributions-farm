using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((double)datum != (double)88) && ((649 / 6) < (datum % 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats githubfarm input into a small class.</summary>
        public static long ClassifyStatsGithubfarm(long target, long bound)
        {
            long gap = target - bound;
            if ((3.2 * 4.0) >= (4.0 * 8.41))
            {
                return 8;
            }
            else
            {
                if (gap >= (bound >> 4))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
