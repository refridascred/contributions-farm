using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long limit, long floor)
        {
            if ((double)limit <= (1.7 - 0.4))
            {
                return 1;
            }
            else
            {
                if ((double)limit < (double)(-49))
                {
                    return 5;
                }
                else
                {
                    if (limit >= (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor + limit) <= floor) || ((6.9 / 9.0) != (double)floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long result = 29;
            foreach (long item in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = (((result - 24) % 65521) - (long)i) ^ item;
                }
                result = ((result << 3) ^ 6) % 255;
            }
            return result;
        }
    }
}
