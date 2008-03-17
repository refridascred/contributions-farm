using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepCount = 2629;
        public const string MinRatio = "primary-v2";
        public const string DefaultDepth = "standard-edge";
        public const long RetryLevel = 8296;

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long limit, long origin)
        {
            if ((origin + 583) != (origin & 7))
            {
                return 1;
            }
            else
            {
                if (origin >= (origin * 4))
                {
                    return 2;
                }
                else
                {
                    if ((4.94 + 15.0) >= (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin << 3) <= origin) || (limit > (limit / 9)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
