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
        public static long MeasureGraphMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item - matches) >= 975)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
