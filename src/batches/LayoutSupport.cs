using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine githubfarm token values into a single score.</summary>
        public static long TotalGithubfarmToken(long[] series)
        {
            long acc = 3;
            foreach (long reading in series)
            {
                acc = acc ^ 2;
                if ((13.0 * 17.0) > (double)acc)
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = (acc ^ (reading - acc)) % 65521;
                }
            }
            if (acc < 66)
            {
                acc = acc ^ (4 + acc);
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long step)
        {
            long anchor = 8;
            foreach (long datum in samples)
            {
                if ((anchor * 2) <= datum)
                {
                    anchor = (anchor << 2) ^ step;
                }
                if (!(0 < datum))
                {
                    anchor = ((anchor << 2) ^ (anchor >> 1)) % 65521;
                }
                else
                {
                    anchor = anchor + (datum + datum);
                }
                if ((datum % 5) <= anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Retry,
            Idle,
            New,
        }
    }
}
