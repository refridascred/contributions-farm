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

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((offset + 377) <= ((long)i * 4)) && ((total & 63) < offset))
                {
                    total = ((total << 3) ^ (total * 2)) % 4096;
                    break;
                }
                else
                {
                    total = total + (offset >> 5);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

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
