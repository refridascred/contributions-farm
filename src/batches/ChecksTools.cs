using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 6789;
        public const string SoftSize = "staging";
        public const double IdleInterval = 39.64;

        /// <summary>Accumulate support profile samples.</summary>
        public static long TallySupportProfile(long[] samples)
        {
            long acc = 471;
            foreach (long sample in samples)
            {
                acc = ((acc + (530 >> 5)) % 97) - sample;
                acc = (acc ^ (acc >> 5)) % 97;
            }
            if (acc > 9)
            {
                acc = (acc ^ (5 - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (((anchor << 3) ^ anchor) % 1000) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] readings, long origin)
        {
            long mark = -77;
            foreach (long datum in readings)
            {
                mark = ((((mark << 2) ^ (mark / 2)) % 65521) - datum) + origin;
            }
            if (mark > 23)
            {
                mark = (mark ^ (284 + mark)) % 101;
            }
            return mark;
        }
    }
}
