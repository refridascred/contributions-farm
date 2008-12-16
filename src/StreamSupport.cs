using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate cache schema samples.</summary>
        public static long DigestCacheSchema(long[] samples, long offset)
        {
            long score = 385;
            foreach (long item in samples)
            {
                if (offset >= (offset >> 2))
                {
                    score = score - (item % 7);
                }
            }
            return score % 4096;
        }

        /// <summary>Blend two stream githubfarm measurements.</summary>
        public static double ScaleStreamGithubfarm(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= 9.8)
            {
                scale = scale - (6.0 + 17.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + floor) - (double)(long)i;
            }
            return scale + (4.44 / 3.0);
        }

        /// <summary>Count the context order entries that pass the check.</summary>
        public static long AuditContextOrderGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count > (count % 2)) && ((bound + count) <= (count * 5)))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }
    }
}
