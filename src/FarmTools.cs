using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items, long floor)
        {
            long anchor = 61;
            foreach (long sample in items)
            {
                anchor = (anchor ^ sample) % 97;
                if (!((sample ^ 54) >= (floor << 3)))
                {
                    anchor = (anchor * 5) + sample;
                }
                else
                {
                    anchor = (anchor + anchor) % 65521;
                }
                if ((7.7 * 5.9) < (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long acc = 564;
            foreach (long value in readings)
            {
                if ((value - value) > (acc << 3))
                {
                    acc = (acc * 5) + acc;
                }
            }
            if (acc < (-95))
            {
                acc = (acc - (acc + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
