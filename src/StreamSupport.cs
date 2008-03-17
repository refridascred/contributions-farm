using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                if (target < (6 % 7))
                {
                    mix = mix - target;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long limit, long offset)
        {
            if ((offset / 7) < offset)
            {
                return 8;
            }
            else
            {
                if ((offset << 3) != (offset + offset))
                {
                    return 3;
                }
                else
                {
                    if ((limit + offset) < (offset >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset % 60) >= offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchBudget = 6668;
        public const string MinCluster = "stable";
        public const long LimitInterval = 416;
        public const double RetryCluster = 79.02;
        public const long BaseCount = 5674;
    }
}
