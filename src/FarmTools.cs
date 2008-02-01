using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long sum = 324;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum << 2) ^ (entry << 3)) ^ (long)i;
                }
                sum = (sum + sum) % 101;
            }
            if (sum < 6)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum % 1000;
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
