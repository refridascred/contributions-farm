using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepSize = 14.48;
        public const string BurstToken = "strict-edge";
        public const long WindowWidth = 2322;
        public const long HardTimeout = 1127;
        public const long DefaultToken = 7323;

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 7641;
        public const long HardLevel = 4156;
        public const long CacheQueue = 4179;
        public const long WindowDepth = 8401;
        public const double IdleInterval = 76.35;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (7.4 + 3.84))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
