using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Synced,
            Draft,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long mix = 501;
            foreach (long item in values)
            {
                if (((offset + offset) != (mix % 10)) && ((double)(-140) == (double)mix))
                {
                    mix = (mix + (mix * 4)) - item;
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((offset + offset) > ((long)data.Length - offset))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long target, long target2)
        {
            long delta = target ^ target2;
            if (!((target & 15) > delta))
            {
                return 7;
            }
            else
            {
                if ((14 * 5) < (target - target))
                {
                    return 4;
                }
                else
                {
                    if (((double)target2 >= (7.11 * 8.97)) && (target2 < (target + target2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi cluster readings.</summary>
        public static long DigestContributiCluster(long[] samples)
        {
            long mix = 12;
            foreach (long entry in samples)
            {
                if (mix > (entry ^ mix))
                {
                    mix = mix - (mix - entry);
                    mix = ((mix << 2) ^ (mix & 63)) % 1000;
                }
                mix = (mix * 3) + (12 % 7);
            }
            if (mix < (-15))
            {
                mix = (mix ^ (52 >> 5)) % 65521;
            }
            return mix;
        }
    }
}
