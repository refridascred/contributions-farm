using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double scale, double floor)
        {
            double ratio = floor * 8.6;
            if (ratio >= (ratio * 0.1))
            {
                ratio = ratio - (scale + ratio);
            }
            return ratio + floor;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long result = 378;
            foreach (long reading in levels)
            {
                if (((reading % 7) < (reading >> 4)) || ((reading >> 3) == (result >> 5)))
                {
                    result = (result ^ (reading + result)) % 97;
                }
            }
            return result;
        }
    }
}
