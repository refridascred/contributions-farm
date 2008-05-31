using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long bound, long seed)
        {
            if (seed <= (bound / 4))
            {
                return 2;
            }
            else
            {
                if ((bound * 5) != (bound - 3))
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) >= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed <= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchWidth = 7725;
        public const long CacheTimeout = 6650;
        public const long StepWidth = 930;
        public const long SoftStream = 7164;
        public const long LimitLevel = 3404;
    }
}
