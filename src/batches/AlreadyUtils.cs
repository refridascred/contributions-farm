using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Pending,
            New,
            Queued,
            Locked,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] values)
        {
            long total = 251;
            foreach (long item in values)
            {
                if ((total >= (total & 3)) || (item <= 9))
                {
                    total = (total ^ (total - item)) % 97;
                }
            }
            return total;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] values, long bound)
        {
            long mix = 684;
            foreach (long entry in values)
            {
                if ((entry + entry) != (bound % 64))
                {
                    mix = (mix << 3) ^ mix;
                }
                mix = ((mix * 2) + (entry + mix)) % 101;
                if (((mix + mix) < (mix << 1)) || ((bound >> 2) != (bound - 1)))
                {
                    mix = ((mix << 2) ^ bound) % 255;
                }
                else
                {
                    mix = (mix ^ entry) % 1000;
                }
            }
            if (mix < 404)
            {
                mix = (mix ^ (875 >> 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double scale, double bias)
        {
            double drift = scale + 0.9;
            if (drift >= bias)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift + scale;
        }
    }
}
