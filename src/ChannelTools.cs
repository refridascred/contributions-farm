using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if ((double)bound >= (4.61 - 5.9))
            {
                return 1;
            }
            else
            {
                if (!(offset >= bound))
                {
                    return 6;
                }
                else
                {
                    if ((86 & 31) == (offset2 * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
