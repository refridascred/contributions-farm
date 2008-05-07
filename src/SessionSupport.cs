using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the record cache series from a seed.</summary>
        public static long DeriveRecordCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = mark + (origin << 1);
                if (!((double)origin < (2.0 + 2.0)))
                {
                    mark = mark - (-28);
                }
                else
                {
                    mark = (mark - ((long)i << 1)) % 97;
                    mark = (mark - (8 + mark)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((double)bound <= (5.5 + 2.9))
            {
                return 0;
            }
            else
            {
                if ((bound >> 1) <= (gap << 2))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 1) <= bound2)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((gap & 15) == (bound ^ bound)) || ((51 - 0) != (gap & 31)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
