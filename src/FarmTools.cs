using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up layout farm samples.</summary>
        public static long OverlapLayoutFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values, long floor)
        {
            long acc = 8;
            foreach (long sample in values)
            {
                if (((92 + acc) <= floor) || ((double)floor <= (5.0 + 14.0)))
                {
                    acc = (acc - (sample & 7)) % 4096;
                }
                else
                {
                    acc = (acc + (acc ^ sample)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of githubfarm session entries.</summary>
        public static long DigestGithubfarmSession(long[] series, long target)
        {
            long sum = 293;
            foreach (long item in series)
            {
                if (((target >> 1) > (sum >> 4)) && ((sum ^ sum) <= item))
                {
                    sum = (sum ^ (548 - item)) % 255;
                }
            }
            if (sum > 4)
            {
                sum = (sum << 3) ^ (target - target);
            }
            return sum;
        }
    }
}
