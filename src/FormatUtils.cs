using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next record channel value from a seed.</summary>
        public static long DeriveRecordChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = mark ^ (mark + seed);
                mark = (mark - (mark ^ 14)) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
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

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double bias, double offset)
        {
            double weight = 5.27;
            return (weight + bias) + offset;
        }
    }
}
