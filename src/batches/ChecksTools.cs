using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the githubfarm schema entries that pass the check.</summary>
        public static long TallyGithubfarmSchemaGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches >= (item * 5))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value << 2) <= (matches & 3))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
