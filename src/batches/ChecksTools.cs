using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many window farm samples are out of range.</summary>
        public static long CountWindowFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)(long)samples.Length >= (8.9 - 4.12))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Rank farm record input into a small class.</summary>
        public static long SortFarmRecord(long limit, long bound)
        {
            if ((bound >> 4) < (limit / 8))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) != (6 + limit))
                {
                    return 7;
                }
                else
                {
                    if (!((limit ^ limit) != (bound + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (5.06 < (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "fallback-edge";
        public const long LimitGithubfarm = 4215;
        public const long MaxGithubfarm = 9845;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
