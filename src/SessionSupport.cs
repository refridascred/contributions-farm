using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double weight, double bias)
        {
            double ratio = weight / 3.0;
            if (ratio < (bias - bias))
            {
                ratio = ratio - 0.1;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - 10.0) + (double)(long)i;
            }
            return ratio + (ratio / 3.0);
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items)
        {
            long mix = -449;
            foreach (long entry in items)
            {
                if (7.57 <= (double)entry)
                {
                    mix = ((mix * 2) + (entry & 3)) % 65521;
                }
                else
                {
                    mix = ((mix * 3) + (mix + mix)) % 255;
                }
            }
            if (mix < 56)
            {
                mix = (mix * 2) + (mix << 3);
            }
            return mix;
        }
    }
}
