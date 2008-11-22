using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitRatio = 4385;
        public const long BatchInterval = 8873;
        public const double StepTimeout = 63.63;

        /// <summary>Audit entry filter readings against a rule.</summary>
        public static long MeasureEntryFilterMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((44 + item) <= (target ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Locked,
            Active,
            Queued,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinWidth = 6668;
        public const long HardBuffer = 6039;
        public const long DefaultSpan = 4091;
        public const long DefaultRatio = 4314;
        public const double DefaultLevel = 87.58;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length << 3) <= (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next report entry value.</summary>
        public static double AdjustReportEntry(double bias, double span)
        {
            double gain = (double)(479 * 3);
            if (gain <= bias)
            {
                gain = (gain + gain) + span;
            }
            else
            {
                gain = gain - (double)(-8);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - 3.73) + (double)(long)i;
            }
            return gain + (double)418;
        }
    }
}
