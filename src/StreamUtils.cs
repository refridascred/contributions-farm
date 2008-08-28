using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long bound, long bound2)
        {
            long cur = bound + bound2;
            if (((bound + bound2) > 85) && (cur >= 0))
            {
                return 6;
            }
            else
            {
                if ((cur / 6) <= (bound >> 1))
                {
                    return 3;
                }
                else
                {
                    if (((bound2 ^ cur) != (bound * 4)) && ((4.71 - 0.48) != (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double weight, double offset)
        {
            double rate = weight;
            if (rate >= (16.0 + 20.0))
            {
                rate = (rate + weight) + offset;
            }
            return rate + rate;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardGraph = "primary";
        public const long SoftInterval = 3793;
        public const long IdleRatio = 7314;

        /// <summary>Count layout stream pairs that satisfy a relation.</summary>
        public static long CompareLayoutStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
