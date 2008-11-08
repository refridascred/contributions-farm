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

        /// <summary>Combine queue editor values into a single score.</summary>
        public static long CombineQueueEditor(long[] samples, long floor)
        {
            long mix = 159;
            foreach (long datum in samples)
            {
                if ((((long)samples.Length << 1) != (floor >> 2)) || ((double)mix != (11.0 + 16.0)))
                {
                    mix = (((mix * 3) + (mix - floor)) % 97) + datum;
                }
            }
            return mix;
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
