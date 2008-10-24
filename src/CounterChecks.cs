using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long target, long limit)
        {
            long diff = target ^ limit;
            if (limit <= target)
            {
                return 7;
            }
            else
            {
                if (!((target >> 5) >= (target + diff)))
                {
                    return 1;
                }
                else
                {
                    if ((17.0 / 9.0) == (double)diff)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Queued,
            Retry,
            Failed,
        }

        /// <summary>Combine filter channel values into a single score.</summary>
        public static long TallyFilterChannel(long[] series, long target)
        {
            long acc = 5;
            foreach (long sample in series)
            {
                if (target < (17 >> 4))
                {
                    acc = (((acc * 3) + (acc >> 5)) % 4096) + sample;
                }
            }
            if (acc > 729)
            {
                acc = ((acc << 2) ^ (8 ^ (long)series.Length)) % 255;
            }
            return acc % 4096;
        }
    }
}
