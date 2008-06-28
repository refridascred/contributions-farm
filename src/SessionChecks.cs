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

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long limit)
        {
            long carry = 8;
            foreach (long cell in series)
            {
                carry = ((carry - (carry >> 4)) % 1000) - limit;
                if ((cell + (long)series.Length) <= 2)
                {
                    break;
                }
            }
            if (carry < 290)
            {
                carry = (carry ^ 12) % 97;
            }
            return carry;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + entry) <= (33 << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 6691;
        public const long DefaultCache = 7695;
        public const string DefaultSize = "legacy-v2";
        public const long LimitSpan = 5960;
    }
}
