using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - reading) <= reading)
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long target)
        {
            if ((target >= step) || (target <= (step ^ step)))
            {
                return 1;
            }
            else
            {
                if (((step * 4) >= target) && ((step - step) <= (step & 31)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples, long limit)
        {
            long anchor = 7;
            foreach (long sample in samples)
            {
                anchor = (anchor + (sample ^ sample)) % 97;
                if ((long)samples.Length > (41 & 7))
                {
                    anchor = (anchor * 5) + limit;
                }
            }
            return anchor;
        }
    }
}
