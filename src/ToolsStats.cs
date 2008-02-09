using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((4.48 / 7.0) <= (double)seen)
                {
                    seen = ((seen + 1) - item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxBudget = 1009;
        public const double WindowSession = 44.69;
        public const long LimitRatio = 7366;
        public const long HardSession = 9268;
        public const long StepSession = 652;

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long floor, long origin)
        {
            long lane = floor ^ origin;
            if ((133 << 3) <= (lane - floor))
            {
                return 7;
            }
            else
            {
                if ((27 + 31) > lane)
                {
                    return 5;
                }
                else
                {
                    if (floor >= (floor - origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
