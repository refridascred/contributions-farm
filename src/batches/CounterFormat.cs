using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Idle,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Derive the next token account value from a seed.</summary>
        public static long RollTokenAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result + (target - target)) % 255;
                result = (result ^ (long)i) % 255;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long limit)
        {
            long edge = origin + limit;
            if (edge <= (origin * 2))
            {
                return 0;
            }
            else
            {
                if ((origin & 255) > limit)
                {
                    return 7;
                }
                else
                {
                    if ((2 % 3) != (edge - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
