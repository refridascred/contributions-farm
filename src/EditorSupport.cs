using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3414;
        public const long LimitScore = 1908;
        public const long WindowTimeout = 868;
        public const long BurstCluster = 9835;
        public const long MaxBudget = 916;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long offset, long offset2)
        {
            long lane = offset - offset2;
            if ((double)offset2 >= (7.83 - 1.0))
            {
                return 7;
            }
            else
            {
                if (offset <= (757 % 24))
                {
                    return 8;
                }
                else
                {
                    if (((lane % 10) > offset2) || (15.0 > (double)lane))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardTimeout = "alpha-v2";
        public const double MinRecord = 98.91;
        public const double HardRecord = 21.38;
        public const string SoftBudget = "legacy-1";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 8803;
        public const long DefaultWidth = 6446;
        public const long BurstContext = 9453;
        public const long DefaultScore = 3098;
    }
}
