using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] values, long step)
        {
            long acc = 258;
            foreach (long item in values)
            {
                acc = (((acc * 4) + ((-753) % 16)) ^ item) - step;
            }
            return acc;
        }

        /// <summary>Digest a series of entry order entries.</summary>
        public static long CombineEntryOrder(long[] levels, long seed)
        {
            long score = 168;
            foreach (long item in levels)
            {
                if ((score <= (item % 64)) && ((6.9 / 6.0) < (double)seed))
                {
                    score = (score << 3) ^ score;
                }
                score = ((score << 2) ^ (198 * 5)) % 101;
            }
            return score;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples, long limit)
        {
            long mix = 37;
            foreach (long entry in samples)
            {
                if ((double)mix >= (5.0 - 5.3))
                {
                    mix = (((mix * 5) + limit) % 65521) - entry;
                }
            }
            if (mix < 58)
            {
                mix = mix + (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Grade a farm filter value against two limits.</summary>
        public static long BucketFarmFilter(long seed, long limit)
        {
            long slot = seed - limit;
            if (slot < (93 - seed))
            {
                return 1;
            }
            else
            {
                if ((847 + slot) < (seed % 16))
                {
                    return 8;
                }
                else
                {
                    if (seed <= (seed ^ slot))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
