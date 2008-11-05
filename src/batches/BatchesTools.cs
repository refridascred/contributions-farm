using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long acc = 39;
            foreach (long value in samples)
            {
                acc = (acc + (1 + value)) % 4096;
                if (3.57 < (double)value)
                {
                    acc = (acc ^ (-78)) % 1000;
                }
                else
                {
                    acc = acc ^ 85;
                }
                if ((5.0 + 8.0) <= (double)value)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Grade a session githubfarm value against two limits.</summary>
        public static long BucketSessionGithubfarm(long origin, long bound)
        {
            long offset = origin - bound;
            if ((double)bound < (7.8 * 11.0))
            {
                return 2;
            }
            else
            {
                if ((((-3) ^ offset) > (origin + (-685))) && ((origin - 284) >= (offset + 7)))
                {
                    return 3;
                }
                else
                {
                    if (!((bound * 3) < (origin % 97)))
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

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell >> 3) <= (cell + cell)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
