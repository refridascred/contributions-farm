using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            New,
            Stale,
            Locked,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell - cell) != (cell + (-4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i << 2) != (304 ^ step))
                {
                    mix = mix + 63;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double span)
        {
            double ratio = (double)(754 & 127);
            if (ratio < 13.0)
            {
                ratio = (ratio + (double)(-1)) - span;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long target, long step)
        {
            long prev = target - step;
            if (!((prev - step) <= (prev ^ target)))
            {
                return 4;
            }
            else
            {
                if ((6 & 127) == (step + prev))
                {
                    return 1;
                }
                else
                {
                    if ((prev ^ prev) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Draft,
            Idle,
        }
    }
}
