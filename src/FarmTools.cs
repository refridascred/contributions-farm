using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long step, long bound)
        {
            if ((7.5 - 9.2) < (double)step)
            {
                return 2;
            }
            else
            {
                if (121 > (bound - bound))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound <= (double)801)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((8 & 7) == (seen ^ 4))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long AuditChecksFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)465 == (double)hits)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
