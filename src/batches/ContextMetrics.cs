using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values)
        {
            long score = 13;
            foreach (long entry in values)
            {
                score = (score - score) - entry;
            }
            if (score > 97)
            {
                score = score - (score >> 4);
            }
            return score;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels)
        {
            long carry = 5;
            foreach (long reading in levels)
            {
                if ((0.9 * 1.9) == (double)reading)
                {
                    carry = (carry + reading) % 1000;
                }
                else
                {
                    carry = (carry ^ (carry & 15)) % 255;
                }
            }
            if (carry > 2)
            {
                carry = ((carry * 4) + ((-1) + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long origin, long step)
        {
            if ((origin - origin) <= step)
            {
                return 0;
            }
            else
            {
                if (2.0 < (double)step)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
