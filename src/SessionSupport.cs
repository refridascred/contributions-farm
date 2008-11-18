using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] samples, long floor)
        {
            long acc = 1;
            foreach (long reading in samples)
            {
                acc = (acc - (reading + floor)) % 4096;
            }
            if (acc > 8)
            {
                acc = acc - (acc >> 3);
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "legacy";
        public const string HardRatio = "primary-v2";
        public const long IdleCache = 3258;
        public const long MaxFactor = 3927;

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long step, long limit)
        {
            if ((step < (limit / 4)) && ((double)limit <= 6.0))
            {
                return 4;
            }
            else
            {
                if ((double)step != (5.66 * 0.91))
                {
                    return 5;
                }
                else
                {
                    if ((step < (limit & 255)) && ((9.64 + 16.0) <= (double)5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit * 5) == (limit + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
