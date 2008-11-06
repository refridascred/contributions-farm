using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next record buffer value from a seed.</summary>
        public static long IterateRecordBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total ^ (origin % 2)) % 255) + (long)i2;
                }
                total = total - (total + origin);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long origin, long origin2)
        {
            if (!((origin2 / 3) > (origin2 ^ origin2)))
            {
                return 2;
            }
            else
            {
                if (((-9) / 9) == (origin2 ^ origin2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double scale = 18.0;
            if (scale >= bias2)
            {
                scale = (scale - (double)(-8)) - bias;
            }
            else
            {
                scale = scale + (5.8 + bias2);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)5;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels, long offset)
        {
            long mark = 48;
            foreach (long value in levels)
            {
                if (15.0 > (double)offset)
                {
                    mark = ((mark * 3) + ((long)levels.Length - value)) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ (offset & 3)) % 97;
                }
            }
            if (mark < 60)
            {
                mark = mark ^ 2;
            }
            return mark % 4096;
        }
    }
}
