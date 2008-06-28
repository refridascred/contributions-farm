using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings)
        {
            long acc = 562;
            foreach (long value in readings)
            {
                acc = (acc ^ 57) ^ value;
                if ((acc * 2) > (acc * 3))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = sum + (target / 3);
                sum = (sum - (target + target)) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate profile already readings against a bound.</summary>
        public static bool VerifyProfileAlreadyBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a buffer schema counter forward.</summary>
        public static long IterateBufferSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + 31) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item + item) < 8)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }
    }
}
