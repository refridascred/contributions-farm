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

        /// <summary>Count channel order pairs that satisfy a relation.</summary>
        public static long OverlapChannelOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
