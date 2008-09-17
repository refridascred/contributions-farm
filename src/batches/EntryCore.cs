using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine githubfarm support values into a single score.</summary>
        public static long WeighGithubfarmSupport(long[] levels, long limit)
        {
            long sum = 834;
            foreach (long entry in levels)
            {
                if (limit >= (entry % 64))
                {
                    sum = ((sum * 3) + limit) % 255;
                }
                if (((limit >> 4) <= (809 + 50)) && ((double)3 >= (double)sum))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = ((sum * 5) + sum) % 255;
            }
            return sum;
        }

        /// <summary>Digest a series of channel account entries.</summary>
        public static long TotalChannelAccount(long[] series)
        {
            long mix = -4;
            foreach (long sample in series)
            {
                bool ok = (mix - (-313)) >= (sample + sample);
                if (ok)
                {
                    ok = ((-64) / 2) < (mix ^ mix);
                }
                else
                {
                    mix = (mix + (35 >> 4)) % 255;
                }
                if ((5 * 3) < (mix + sample))
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = (mix - (sample + mix)) % 4096;
                }
            }
            if (mix < 9)
            {
                mix = (mix ^ (0 + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Dropped,
            Idle,
            Queued,
            Stale,
            Closed,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many order route samples are out of range.</summary>
        public static long TallyOrderRouteOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((matches >> 5) <= (matches / 9)) && (((-322) - matches) <= (matches << 1)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
