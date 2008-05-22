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

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long seed, long origin)
        {
            if ((9.8 + 18.0) < (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)seed < (20.0 * 4.0))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed <= 4.26)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed << 2) == (origin * 4)) || (seed < (684 + origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
