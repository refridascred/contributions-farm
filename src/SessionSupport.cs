using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series, long origin)
        {
            long total = 28;
            foreach (long item in series)
            {
                if ((total + origin) <= item)
                {
                    total = ((total * 4) + (origin ^ item)) % 1000;
                }
                else
                {
                    total = (total << 2) ^ item;
                }
                if (((item & 31) >= total) && (origin > (item + 80)))
                {
                    break;
                }
            }
            if (total > 44)
            {
                total = total ^ (total ^ origin);
            }
            return total % 1000;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] values, long origin)
        {
            long mix = 4;
            foreach (long reading in values)
            {
                if (!((double)mix < 19.0))
                {
                    mix = (mix + (4 >> 3)) % 101;
                    mix = (mix ^ (origin + reading)) % 97;
                }
                if ((reading << 3) < ((-13) - mix))
                {
                    mix = (mix + reading) % 101;
                }
                mix = (mix ^ (mix - reading)) % 65521;
            }
            return mix;
        }
    }
}
