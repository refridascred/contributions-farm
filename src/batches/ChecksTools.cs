using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long step, long floor)
        {
            if ((floor + step) == (step >> 4))
            {
                return 5;
            }
            else
            {
                if (!((floor / 6) <= floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) >= (step + step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor <= step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseRatio = 6891;
        public const long LimitTools = 281;
        public const double BurstTools = 61.26;
        public const double BatchTools = 1.72;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading - reading) < reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
