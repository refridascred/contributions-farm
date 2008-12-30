using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine session support values into a single score.</summary>
        public static long DigestSessionSupport(long[] samples, long step)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    acc = (acc - (sample & 3)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (8.9 + 3.46))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine support githubfarm values into a single score.</summary>
        public static long TotalSupportGithubfarm(long[] series)
        {
            long mark = 642;
            foreach (long datum in series)
            {
                if (!(7.22 > (double)datum))
                {
                    mark = mark + (8 + (-2));
                }
            }
            if (mark < 858)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 97;
            }
            return mark % 97;
        }
    }
}
