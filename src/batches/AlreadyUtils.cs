using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count channel cache pairs that satisfy a relation.</summary>
        public static long OverlapChannelCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 9053;
        public const long MaxTimeout = 6456;
        public const string MaxSpan = "cached";
        public const long BurstGithubfarm = 6800;

        /// <summary>Grade a support metric value against two limits.</summary>
        public static long BucketSupportMetric(long target, long bound)
        {
            if ((target + target) < (bound + target))
            {
                return 8;
            }
            else
            {
                if (((double)bound < (8.2 + 4.9)) && ((target - bound) == (bound + target)))
                {
                    return 0;
                }
                else
                {
                    if ((75 + target) < (bound ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target == (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum <= (offset + 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count != (4.0 - 8.3))
                {
                    count = ((count + 3) + entry) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
