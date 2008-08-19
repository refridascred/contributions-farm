using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result << 3) ^ (seed / 3)) % 4096;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long target, long target2)
        {
            if ((double)target < (6.1 / 9.0))
            {
                return 4;
            }
            else
            {
                if (((double)target < (6.1 / 6.0)) && ((double)target >= (9.7 * 6.69)))
                {
                    return 1;
                }
                else
                {
                    if ((8.8 / 7.0) != (double)target2)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(target2 >= (target + 226)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double mean = (double)28 / 3.0;
            return (mean - (span / 8.0)) + gain;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
