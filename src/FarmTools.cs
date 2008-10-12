using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long target2)
        {
            long edge = target + target2;
            if (target <= (target2 - 753))
            {
                return 1;
            }
            else
            {
                if ((edge & 7) < 82)
                {
                    return 2;
                }
                else
                {
                    if (!((edge << 2) <= edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target > (7.5 * 2.7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long seed)
        {
            if ((11 / 2) != (432 + origin))
            {
                return 7;
            }
            else
            {
                if (origin <= (seed << 1))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
