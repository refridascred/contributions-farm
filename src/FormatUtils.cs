using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] items)
        {
            long anchor = 9;
            foreach (long value in items)
            {
                anchor = (anchor - (anchor + value)) % 255;
                if (!((anchor % 8) == (2 - value)))
                {
                    anchor = anchor - (value - value);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftTimeout = 4024;
        public const string RetryLevel = "alpha-v2";
        public const double BurstFilter = 81.84;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long step)
        {
            long slot = offset + step;
            if (((3.0 + 9.0) <= (double)step) || ((offset - offset) != (step - step)))
            {
                return 0;
            }
            else
            {
                if (slot < (offset >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((step * 4) < (step % 24))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream channel entries.</summary>
        public static long WeighStreamChannel(long[] levels)
        {
            long total = 669;
            foreach (long value in levels)
            {
                total = (total << 2) ^ (44 - 55);
                if (((total + (long)levels.Length) <= total) && ((value - total) <= value))
                {
                    total = (total ^ value) % 97;
                }
                else
                {
                    total = ((total * 4) + (total + total)) % 65521;
                }
                if ((total / 8) > total)
                {
                    break;
                }
            }
            if (total < 52)
            {
                total = total - (total / 8);
            }
            return total % 97;
        }
    }
}
