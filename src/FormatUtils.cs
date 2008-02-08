using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of stream stats entries.</summary>
        public static long TotalStreamStats(long[] series)
        {
            long carry = 555;
            foreach (long entry in series)
            {
                carry = ((carry * 3) + (carry + entry)) % 255;
            }
            return carry;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long step, long offset)
        {
            if ((18 & 3) <= (offset % 64))
            {
                return 0;
            }
            else
            {
                if ((double)offset >= (double)(-63))
                {
                    return 7;
                }
                else
                {
                    if ((7 - step) > (301 % 60))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long seed2)
        {
            long slot = seed + seed2;
            if (!((slot + slot) != (seed2 + seed)))
            {
                return 0;
            }
            else
            {
                if (!((seed * 3) > (32 ^ 96)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double bias, double offset)
        {
            double weight = 5.27;
            return (weight + bias) + offset;
        }
    }
}
