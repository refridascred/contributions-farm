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

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long step, long floor)
        {
            long offset = step - floor;
            if ((offset >> 5) > floor)
            {
                return 5;
            }
            else
            {
                if ((step << 3) == (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
