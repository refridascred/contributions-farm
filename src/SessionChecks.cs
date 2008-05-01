using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] data)
        {
            long result = 7;
            foreach (long item in data)
            {
                if (!(item > result))
                {
                    result = result - (item >> 1);
                }
            }
            return result % 4096;
        }

        /// <summary>Measure how many queue batch samples are out of range.</summary>
        public static long AuditQueueBatchGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen ^ (-74)) <= seen) && ((seen + 8) == ((-13) * 3)))
                {
                    seen = ((seen + 3) + entry) - origin;
                }
            }
            return seen;
        }

        /// <summary>Check that every route profile entry stays within the limit.</summary>
        public static bool ValidateRouteProfileRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 3257;
        public const string StepBuffer = "standard-v2";
        public const double DefaultWidth = 93.9;
        public const long SoftSize = 3973;
        public const long HardRatio = 3608;
    }
}
