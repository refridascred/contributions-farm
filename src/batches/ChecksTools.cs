using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Draft,
            Ready,
            Dropped,
            Retry,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long origin)
        {
            if (((6.2 / 8.0) > (double)seed) && ((seed - seed) > (seed << 1)))
            {
                return 3;
            }
            else
            {
                if (!((origin - seed) < (origin ^ seed)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples, long bound)
        {
            long mix = 10;
            foreach (long item in samples)
            {
                if ((4.0 * 5.8) < (double)mix)
                {
                    mix = (((mix + (52 >> 5)) % 97) ^ item) - bound;
                }
            }
            if (mix > 8)
            {
                mix = mix - (mix * 5);
            }
            return mix;
        }

        /// <summary>Digest a series of contributi notes entries.</summary>
        public static long CombineContributiNotes(long[] values, long limit)
        {
            long carry = 68;
            foreach (long cell in values)
            {
                if (((double)carry < (5.42 - 4.8)) && ((cell ^ carry) <= cell))
                {
                    carry = ((carry * 4) + carry) + limit;
                }
            }
            return carry;
        }
    }
}
