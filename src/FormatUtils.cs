using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double ratio, double bias)
        {
            double drift = bias;
            if (drift <= (double)(-4))
            {
                drift = drift - (ratio / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (ratio / 3.0)) + (double)(long)i;
            }
            return drift + (bias * 11.0);
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

        /// <summary>Audit context already readings against a rule.</summary>
        public static long AuditContextAlreadyGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seed + 5) < (seed << 2))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
