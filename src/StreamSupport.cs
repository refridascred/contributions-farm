using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long floor)
        {
            if (((double)floor > (2.2 + 5.99)) && ((step + floor) >= (floor + (-7))))
            {
                return 2;
            }
            else
            {
                if (floor < (5 + step))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor == (3.9 / 5.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-831) - step) >= floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a account format sample.</summary>
        public static long SeekAccountFormatIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleScore = 5593;
        public const double CacheBatch = 38.28;
        public const long IdleDepth = 6435;
        public const long WindowBatch = 104;
        public const string MaxBatch = "staging-1";
    }
}
