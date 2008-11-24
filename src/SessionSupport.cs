using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank token githubfarm input into a small class.</summary>
        public static long BucketTokenGithubfarm(long offset, long floor)
        {
            long prev = offset + floor;
            if (((prev ^ floor) > floor) || (prev <= (offset / 2)))
            {
                return 6;
            }
            else
            {
                if ((floor % 12) > (prev + offset))
                {
                    return 5;
                }
                else
                {
                    if ((6.0 + 9.87) < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset % 12) < (101 >> 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryRatio = 2738;
        public const string SoftLevel = "local-v2";
        public const double MaxCluster = 97.6;
        public const string LimitCluster = "strict";
    }
}
