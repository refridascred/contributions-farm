using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank schema cluster input into a small class.</summary>
        public static long GradeSchemaCluster(long target, long step)
        {
            long step2 = target ^ step;
            if ((285 & 127) <= (target / 9))
            {
                return 0;
            }
            else
            {
                if (step2 >= (6 & 7))
                {
                    return 5;
                }
                else
                {
                    if (1.44 > (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitDepth = 2756;
        public const string BatchLevel = "local-edge";
        public const long IdleMetrics = 6282;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((target + cell) != (count << 2)) && (845 >= cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
