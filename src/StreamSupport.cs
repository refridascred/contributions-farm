using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Synced,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Iterate the githubfarm schema series from a seed.</summary>
        public static long SeriesGithubfarmSchema(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (mark - (bound / 8)) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long offset)
        {
            if ((8 + offset) > offset)
            {
                return 3;
            }
            else
            {
                if (((6.36 / 4.0) == (double)offset) && ((double)offset >= (double)55))
                {
                    return 5;
                }
                else
                {
                    if ((0.5 - 2.0) == (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset << 2) <= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
