using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a cluster context counter forward.</summary>
        public static long RollClusterContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a farm route value against two limits.</summary>
        public static long SortFarmRoute(long limit, long step)
        {
            long offset = limit + step;
            if (((double)offset <= (1.5 + 8.21)) || ((double)step >= 4.6))
            {
                return 5;
            }
            else
            {
                if ((offset ^ limit) >= (offset + limit))
                {
                    return 7;
                }
                else
                {
                    if (step > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitScore = "alpha-edge";
        public const long DefaultSession = 1594;
        public const long SoftBudget = 9663;
    }
}
