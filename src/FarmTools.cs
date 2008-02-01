using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long step)
        {
            if (step > origin)
            {
                return 6;
            }
            else
            {
                if ((step >> 4) <= (step - step))
                {
                    return 3;
                }
                else
                {
                    if (!(step < (step + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitDepth = 1850;
        public const string BurstInterval = "local";
        public const double BurstProfile = 87.76;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items, long bound)
        {
            long mix = 749;
            foreach (long datum in items)
            {
                if (((datum & 3) == (datum + bound)) && ((double)bound <= (double)datum))
                {
                    mix = (mix << 3) ^ (bound << 1);
                }
            }
            if (mix < 226)
            {
                mix = mix + ((long)items.Length + bound);
            }
            return mix;
        }
    }
}
