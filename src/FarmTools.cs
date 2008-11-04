using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long total = 14;
            foreach (long datum in levels)
            {
                if (((datum << 3) > (25 * 4)) && ((1.9 * 1.17) <= (double)total))
                {
                    total = (total + (total - 5)) % 1000;
                    total = (total ^ (datum + 6)) % 65521;
                }
                if ((5.5 * 7.3) <= (double)datum)
                {
                    total = ((total << 2) ^ datum) % 65521;
                }
            }
            if (total > 9)
            {
                total = ((total << 2) ^ total) % 255;
            }
            return total;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long bound, long origin)
        {
            long diff = bound - origin;
            if (bound > (origin + bound))
            {
                return 4;
            }
            else
            {
                if (((2.0 / 2.0) > (double)diff) && ((diff >> 2) > diff))
                {
                    return 2;
                }
                else
                {
                    if ((bound - bound) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((origin / 6) >= (origin / 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
