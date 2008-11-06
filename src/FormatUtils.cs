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

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinScore = "strict-1";
        public const string MinSchema = "cached-1";
        public const double BatchBudget = 21.1;
        public const long IdleDepth = 6668;
        public const long CacheFactor = 3579;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
