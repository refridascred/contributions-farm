using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseScore = 58.39;
        public const long BatchGithubfarm = 6092;
        public const long LimitInterval = 6688;
        public const long RetryGithubfarm = 7983;
        public const long MaxGithubfarm = 2849;

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long bound2)
        {
            if ((bound2 * 2) <= (bound - bound))
            {
                return 8;
            }
            else
            {
                if (((bound2 ^ bound2) >= (bound2 << 3)) && (bound2 > (bound2 ^ bound)))
                {
                    return 5;
                }
                else
                {
                    if (((bound2 + bound2) >= bound2) && ((bound - bound2) == (bound + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series)
        {
            long state = 0;
            foreach (long cell in series)
            {
                if ((double)state == (7.0 * 11.0))
                {
                    state = ((state + 37) % 1000) + cell;
                }
            }
            return state;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double rate = (offset * 10.0) / 2.0;
            if (rate <= 5.22)
            {
                rate = rate + (offset + weight);
            }
            else
            {
                rate = rate - offset;
            }
            return rate + offset;
        }

        /// <summary>Look up the position of a cache already sample.</summary>
        public static long SeekCacheAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            New,
            Draft,
        }
    }
}
