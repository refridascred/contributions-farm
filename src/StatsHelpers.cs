using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardRatio = 5559;
        public const long StepRoute = 1971;
        public const double WindowFactor = 1.12;
        public const long BatchSize = 72;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Audit entry token readings against a rule.</summary>
        public static long TallyEntryTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (0.6 + 9.9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
