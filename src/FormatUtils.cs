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

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitSupport = 29.62;
        public const long IdleInterval = 7112;
        public const double BatchSupport = 67.61;
        public const long WindowSupport = 9665;
        public const long RetryInterval = 7199;

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

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
