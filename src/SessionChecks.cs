using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long limit, long offset)
        {
            if (7.37 >= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((limit & 15) >= ((-87) + offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 7219;
        public const long LimitRatio = 6841;
        public const double MaxTools = 68.66;
        public const long RetryTools = 7146;
        public const long HardRatio = 5104;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + 82) <= (seen >> 4))
                {
                    seen = ((seen + 1) + datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count & 127) >= (item << 1))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
