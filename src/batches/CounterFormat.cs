using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a cache tools value against two limits.</summary>
        public static long BucketCacheTools(long step, long limit)
        {
            if ((limit >= 44) && ((limit >> 5) <= (step * 4)))
            {
                return 5;
            }
            else
            {
                if (!(2.9 <= (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 3) == (limit & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit & 7) < (247 / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6278;
        public const string IdleAccount = "primary";
        public const long BaseAccount = 3070;
        public const string DefaultAccount = "latest-1";
        public const long HardScore = 1306;

        /// <summary>Derive the next metrics tools value from a seed.</summary>
        public static long IterateMetricsTools(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)anchor < (double)(long)i))
                {
                    anchor = ((anchor * 2) + (anchor >> 2)) % 1000;
                    anchor = (anchor + (origin + (long)i)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
