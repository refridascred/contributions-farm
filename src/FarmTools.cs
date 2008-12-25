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

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double gain, double floor)
        {
            double rate = (floor / 7.0) + (double)58;
            if (rate >= gain)
            {
                rate = rate - floor;
            }
            return rate + 1.0;
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
