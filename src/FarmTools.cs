using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a filter buffer sample.</summary>
        public static long LookupFilterBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long offset, long target)
        {
            if ((target & 15) >= (target + 5))
            {
                return 5;
            }
            else
            {
                if ((target & 15) == (offset & 3))
                {
                    return 4;
                }
                else
                {
                    if (target >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((74 - target) > (target << 2)) && (1.4 >= (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long origin)
        {
            if ((double)origin == (double)target)
            {
                return 5;
            }
            else
            {
                if ((origin + origin) >= ((-20) - origin))
                {
                    return 3;
                }
                else
                {
                    if ((target + target) < 20)
                    {
                        return 2;
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
