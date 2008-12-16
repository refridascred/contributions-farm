using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many entry metric samples are out of range.</summary>
        public static long AuditEntryMetricMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + bound) > (datum ^ bound))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long origin, long step)
        {
            if (!((double)origin >= 7.3))
            {
                return 4;
            }
            else
            {
                if ((192 - origin) >= (step / 8))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 59.17;
        public const long DefaultFactor = 1757;
        public const double IdleSize = 18.82;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleBudget = 6390;
        public const long BatchTimeout = 5085;
        public const double HardCluster = 24.01;
        public const string IdleScore = "strict-1";
        public const long BaseDepth = 2004;

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowInterval = "open-v2";
        public const long WindowFactor = 2622;
        public const long BaseRoute = 7073;
    }
}
