using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSpan = 1854;
        public const long IdleInterval = 3908;
        public const long HardSession = 5358;

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double mean = 3.0;
            if (mean < scale)
            {
                mean = mean + (double)4;
            }
            else
            {
                mean = mean + (span / 9.0);
            }
            return mean + span;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((69 - 21) > (floor % 64))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultLevel = "legacy-1";
        public const long StepBuffer = 8754;
        public const long LimitBuffer = 4370;
        public const long MinBuffer = 3582;
        public const long WindowWidth = 224;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
